using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.Networks.Models;
using HetznerCloud.Net.Objects.Networks.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Networks : BaseEndpoint<SingleNetworkRequestResult, NetworksRequestResult, Network>,
        IDeleteObject
    {
        private const string _endpointPath = "/networks";
        
        private BaseEndpointDelete<SingleNetworkRequestResult, NetworksRequestResult, Network>
            _baseDelete;
        
        public Networks(string apiToken) : base(apiToken, _endpointPath)
        {
            _baseDelete =
                new BaseEndpointDelete<SingleNetworkRequestResult, NetworksRequestResult, Network>(apiToken,
                    _endpointPath);
        }

        public void Delete(long id)
        {
            _baseDelete.Delete(id);
        }
    }
}