using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.Datacenters.Models;
using HetznerCloud.Net.Objects.Datacenters.RequestResults;
using HetznerCloud.Net.Objects.Networks.Models;
using HetznerCloud.Net.Objects.Networks.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Networks : IGetObject<Network>, IGetAllObjects<Network>, IDeleteObject
    {
        private const string EndpointPath = "/networks";
        
        private readonly EndpointService<SingleNetworkRequestResult, NetworksRequestResult, Network>
            _endpointService;
        
        public Networks(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleNetworkRequestResult, NetworksRequestResult, Network>(apiToken, EndpointPath);
        }

        public async Task<Network> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<Network>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }

        public void Delete(long id)
        {
            _endpointService.Delete(id);
        }
    }
}