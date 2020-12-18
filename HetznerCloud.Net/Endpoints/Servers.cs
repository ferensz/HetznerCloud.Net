using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.Servers.Models;
using HetznerCloud.Net.Objects.Servers.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Servers : IGetObject<Server>, IGetAllObjects<Server>, IDeleteObject
    {
        private const string EndpointPath = "/servers";
        
        private readonly EndpointService<SingleServerRequestResult, ServersRequestResult, Server>
            _endpointService;
        
        public Servers(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleServerRequestResult, ServersRequestResult, Server>(apiToken, EndpointPath);
        }
        
        public async Task<Server> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<Server>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }

        public void Delete(long id)
        {
            _endpointService.Delete(id);
        }
    }
}