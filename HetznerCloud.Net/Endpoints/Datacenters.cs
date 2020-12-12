using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Objects.Datacenters;

namespace HetznerCloud.Net.Endpoints
{
    public class Datacenters : BaseEndpoint<SingleDatacenterRequestResult, DatacentersRequestResult, Datacenter>
    {
        public Datacenters(string apiToken) : base(apiToken, "/datacenters")
        {
        }
        
        public async Task<int> GetRecommendedDatacenterIdAsync()
        {
            var res = await SendRequest("/datacenters");
            var datacentersPage = JsonSerializer.Deserialize<DatacentersRequestResult>(res, Settings.JsonSerializerOptions);

            return datacentersPage.Recommendation;
        }
    }
}