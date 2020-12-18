using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.Common;
using HetznerCloud.Net.Objects.ServerTypes.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class ServerTypes : IGetObject<ServerType>, IGetAllObjects<ServerType>
    {
        private const string EndpointPath = "/server_types";
        
        private readonly EndpointService<SingleServerTypeRequestResult, ServerTypesRequestResult, ServerType>
            _endpointService;
        
        public ServerTypes(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleServerTypeRequestResult, ServerTypesRequestResult, ServerType>(apiToken, EndpointPath);
        }
        
        public async Task<ServerType> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<ServerType>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }
    }
}