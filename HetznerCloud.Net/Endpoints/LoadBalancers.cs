using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.LoadBalancers.Models;
using HetznerCloud.Net.Objects.LoadBalancers.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class LoadBalancers : BaseEndpoint<SingleLoadBalancerRequestResult, LoadBalancersRequestResult, LoadBalancer>,
        IDeleteObject
    {
        private const string _endpointPath = "/load_balancers";
        
        private BaseEndpointDelete<SingleLoadBalancerRequestResult, LoadBalancersRequestResult, LoadBalancer>
            _baseDelete;
        
        public LoadBalancers(string apiToken) : base(apiToken, _endpointPath)
        {
            _baseDelete = new BaseEndpointDelete<SingleLoadBalancerRequestResult, LoadBalancersRequestResult, LoadBalancer>(apiToken, _endpointPath);
        }


        public void Delete(long id)
        {
            _baseDelete.Delete(id);
        }
    }
}