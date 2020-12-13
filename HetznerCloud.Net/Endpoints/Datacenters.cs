using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Objects.Datacenters;
using HetznerCloud.Net.Objects.Datacenters.Models;
using HetznerCloud.Net.Objects.Datacenters.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Datacenters : BaseEndpoint<SingleDatacenterRequestResult, DatacentersRequestResult, Datacenter>
    {
        private const string _endpointPath = "/datacenters";
        
        public Datacenters(string apiToken) : base(apiToken, _endpointPath)
        {
        }
        
        public async Task<int> GetRecommendedDatacenterIdAsync()
        {
            var res = await SendRequest(_endpointPath);
            var datacentersPage = JsonSerializer.Deserialize<DatacentersRequestResult>(res, Settings.JsonSerializerOptions);

            return datacentersPage.Recommendation;
        }
    }
}