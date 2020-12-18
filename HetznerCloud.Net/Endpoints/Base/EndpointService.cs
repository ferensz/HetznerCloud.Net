using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints.Base
{
    public class EndpointService<TS, TM, T> : BaseEndpoint 
        where TS : SingleObjectResultBase<T>, new()
        where TM : MultipleObjectsResultBase<T>, new()
    {
        private readonly string _endpointPath;
        
        public EndpointService(string apiToken, string endPointPath) : base(apiToken, endPointPath)
        {
            _endpointPath = endPointPath;
        }

        public async Task<T> GetAsync(long id)
        {
            var res = await SendRequest($"{_endpointPath}/{id}");
            var objectResult = JsonSerializer.Deserialize<TS>(res, Settings.JsonSerializerOptions);
        
            // ReSharper disable once PossibleNullReferenceException
            // If the objectResult is null then an exception has been already thrown
            return objectResult.Data;
        }
        
        /// <summary>
        /// Generic method to get all items from API with type specified by the type parameter
        /// </summary>
        /// <returns>List of items with type specified by the type parameter</returns>
        public async Task<List<T>> GetAllAsync()
        {
            List<T> resultActions = new List<T>();
             
            var res = await SendRequest(_endpointPath);
            var objectsResultPage = JsonSerializer.Deserialize<TM>(res, Settings.JsonSerializerOptions);
        
            if (objectsResultPage != null)
            {
                var lastPage = objectsResultPage.Meta.Pagination.LastPage;
                
                resultActions.AddRange(objectsResultPage.Data);
        
                while (objectsResultPage.Meta.Pagination.Page < lastPage)
                {
                    res = await SendRequest($"{_endpointPath}?page={objectsResultPage.Meta.Pagination.NextPage}");
                    objectsResultPage = JsonSerializer.Deserialize<TM>(res, Settings.JsonSerializerOptions);
            
                    // ReSharper disable once PossibleNullReferenceException
                    // If the objectResult is null then an exception has been already thrown
                    resultActions.AddRange(objectsResultPage.Data);
                }
            }
        
            return resultActions;
        }
        
        public async Task<T> CreateAsync<TC>(TC objectToCreate) where TC : CreateObjectBase, new() 
        {
            objectToCreate.ValidateObject();
            
            var res = await SendPostRequest(_endpointPath, objectToCreate);
            var createdObject =
                JsonSerializer.Deserialize<TS>(res, Settings.JsonSerializerOptions);

            return createdObject.Data;
        }
        
        public async Task<T> UpdateAsync<TU>(long id, TU objectToUpdate) where TU : UpdateObjectBase, new()
        {
            var res = await SendPutRequest($"{_endpointPath}/{id}", objectToUpdate);
            var createdObject =
                JsonSerializer.Deserialize<TS>(res, Settings.JsonSerializerOptions);

            return createdObject.Data;
        }
        
        /// <summary>
        /// Generic method to delete an item through the API with the given Id
        /// </summary>
        /// <param name="id">Id of the item to be deleted</param>
        public void Delete(long id)
        {
            SendDeleteRequest($"{_endpointPath}/{id}", null);
        }
    }
}