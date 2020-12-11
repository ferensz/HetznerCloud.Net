using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Objects.Datacenters;

namespace HetznerCloud.Net.Endpoints
{
    public class Datacenters : BaseEndpoint
    {
        public Datacenters(string apiToken) : base(apiToken)
        {
        }
        
        public async Task<Datacenter> GetDatacenterAsync(long id)
        {
            var res = await SendRequest($"/datacenters/{id}");
            var datacenterResult = JsonSerializer.Deserialize<SingleDatacenterRequestResult>(res, Settings.JsonSerializerOptions);

            return datacenterResult.Datacenter;
        }
        
        public async Task<List<Datacenter>> GetAllDatacentersAsync()
        {
            List<Datacenter> resultActions = new List<Datacenter>();
             
            var res = await SendRequest("/datacenters");
            var datacentersPage = JsonSerializer.Deserialize<DatacentersRequestResult>(res, Settings.JsonSerializerOptions);

            if (datacentersPage != null)
            {
                var lastPage = datacentersPage.Meta.Pagination.LastPage;
                
                resultActions.AddRange(datacentersPage.Datacenters);

                while (datacentersPage.Meta.Pagination.Page < lastPage)
                {
                    res = await SendRequest("/datacenters");
                    datacentersPage = JsonSerializer.Deserialize<DatacentersRequestResult>(res, Settings.JsonSerializerOptions);
                    
                    resultActions.AddRange(datacentersPage.Datacenters);
                }
            }

            return resultActions;
        }
        
        public async Task<int> GetRecommendedDatacenterIdAsync()
        {
            var res = await SendRequest("/datacenters");
            var datacentersPage = JsonSerializer.Deserialize<DatacentersRequestResult>(res, Settings.JsonSerializerOptions);

            return datacentersPage.Recommendation;
        }
    }
}