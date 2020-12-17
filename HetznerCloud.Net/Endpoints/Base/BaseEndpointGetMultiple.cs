using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints.Base
{
    public class BaseEndpointGetMultiple<TM, T> : BaseEndpoint where TM : MultipleObjectsResultBase<T>
    {
        private readonly string _endPointPath;
        
        public BaseEndpointGetMultiple(string apiToken, string endPointPath) : base(apiToken, endPointPath)
        {
            _endPointPath = endPointPath;
        }
        
        /// <summary>
        /// Generic method to get all items from API with type specified by the type parameter
        /// </summary>
        /// <returns>List of items with type specified by the type parameter</returns>
        public async Task<List<T>> GetAllAsync()
        {
            List<T> resultActions = new List<T>();
             
            var res = await SendRequest(_endPointPath);
            var objectsResultPage = JsonSerializer.Deserialize<TM>(res, Settings.JsonSerializerOptions);
        
            if (objectsResultPage != null)
            {
                var lastPage = objectsResultPage.Meta.Pagination.LastPage;
                
                resultActions.AddRange(objectsResultPage.Data);
        
                while (objectsResultPage.Meta.Pagination.Page < lastPage)
                {
                    res = await SendRequest($"{_endPointPath}?page={objectsResultPage.Meta.Pagination.NextPage}");
                    objectsResultPage = JsonSerializer.Deserialize<TM>(res, Settings.JsonSerializerOptions);
            
                    // ReSharper disable once PossibleNullReferenceException
                    // If the objectResult is null then an exception has been already thrown
                    resultActions.AddRange(objectsResultPage.Data);
                }
            }
        
            return resultActions;
        }
    }
}