using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.Common;
using HetznerCloud.Net.Objects.LoadBalancerTypes.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class LoadBalancerTypes : IGetObject<LoadBalancerType>, IGetAllObjects<LoadBalancerType>
    {
        private const string EndpointPath = "/load_balancers";
        
        private readonly EndpointService<SingleLoadBalancerTypesRequestResult, LoadBalancerTypesRequestResult, LoadBalancerType>
            _endpointService;
        
        public LoadBalancerTypes(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleLoadBalancerTypesRequestResult, LoadBalancerTypesRequestResult, LoadBalancerType>(apiToken,
                    EndpointPath);
        }
        
        public async Task<LoadBalancerType> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<LoadBalancerType>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }
    }
}