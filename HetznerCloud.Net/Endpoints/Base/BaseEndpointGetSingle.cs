using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints.Base
{
    public class BaseEndpointGetSingle<TS, T> : BaseEndpoint where TS : SingleObjectResultBase<T>
    {
        private readonly string _endPointPath;
        
        public BaseEndpointGetSingle(string apiToken, string endPointPath) : base(apiToken, endPointPath)
        {
            _endPointPath = endPointPath;
        }
        
        /// <summary>
        /// Generic method to get a single item from API with the given Id with type specified by the type parameter
        /// </summary>
        /// <param name="id">Id of the item</param>
        /// <returns>Single item with type specified by the type parameter</returns>
        public virtual async Task<T> GetAsync(long id)
        {
            var res = await SendRequest($"{_endPointPath}/{id}");
            var objectResult = JsonSerializer.Deserialize<TS>(res, Settings.JsonSerializerOptions);
        
            // ReSharper disable once PossibleNullReferenceException
            // If the objectResult is null then an exception has been already thrown
            return objectResult.Data;
        }
    }
}