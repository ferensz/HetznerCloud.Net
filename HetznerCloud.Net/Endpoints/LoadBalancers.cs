using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.LoadBalancers.Models;
using HetznerCloud.Net.Objects.LoadBalancers.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class LoadBalancers : IGetObject<LoadBalancer>, IGetAllObjects<LoadBalancer>, IDeleteObject
    {
        private const string EndpointPath = "/load_balancers";
        
        private readonly EndpointService<SingleLoadBalancerRequestResult, LoadBalancersRequestResult, LoadBalancer>
            _endpointService;
        
        public LoadBalancers(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleLoadBalancerRequestResult, LoadBalancersRequestResult, LoadBalancer>(apiToken,
                    EndpointPath);
        }

        public async Task<LoadBalancer> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<LoadBalancer>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }

        public void Delete(long id)
        {
            _endpointService.Delete(id);
        }
    }
}