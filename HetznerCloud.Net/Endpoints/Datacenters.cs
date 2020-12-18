using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.Datacenters;
using HetznerCloud.Net.Objects.Datacenters.Models;
using HetznerCloud.Net.Objects.Datacenters.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Datacenters : 
        IGetObject<Datacenter>,
        IGetAllObjects<Datacenter>
    {
        private const string EndpointPath = "/datacenters";

        private readonly EndpointService<SingleDatacenterRequestResult, DatacentersRequestResult, Datacenter>
            _endpointService;
        
        public Datacenters(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleDatacenterRequestResult, DatacentersRequestResult, Datacenter>(apiToken,
                    EndpointPath);
        }
        
        public async Task<Datacenter> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<Datacenter>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }
        
        public async Task<int> GetRecommendedDatacenterIdAsync()
        {
            var res = await _endpointService.SendRequest(EndpointPath);
            var datacentersPage = JsonSerializer.Deserialize<DatacentersRequestResult>(res, Settings.JsonSerializerOptions);

            return datacentersPage.Recommendation;
        }
    }
}