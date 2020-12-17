using HetznerCloud.Net.Objects;

namespace HetznerCloud.Net.Endpoints.Base
{
    public class BaseEndpointDelete : BaseEndpoint
    {
        private readonly string _endPointPath;
        
        public BaseEndpointDelete(string apiToken, string endPointPath) : base(apiToken, endPointPath)
        {
            _endPointPath = endPointPath;
        }
        
        /// <summary>
        /// Generic method to delete an item through the API with the given Id
        /// </summary>
        /// <param name="id">Id of the item to be deleted</param>
        public void Delete(long id)
        {
            SendDeleteRequest($"{_endPointPath}/{id}", null);
        }
    }
}