using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects;
using HetznerCloud.Net.Objects.Actions;
using HetznerCloud.Net.Objects.Actions.Models;
using HetznerCloud.Net.Objects.Actions.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Actions : IGetObject<Action>
    {
        private const string EndpointPath = "/actions";

        private readonly BaseEndpointGetSingle<SingleActionRequestResult, Action> _baseGetObjectEndpoint;
        
        public Actions(string apiToken)
        {
            _baseGetObjectEndpoint =
                new BaseEndpointGetSingle<SingleActionRequestResult, Action>(apiToken, EndpointPath);
        }

        public async Task<Action> GetAsync(long id)
        {
            return await _baseGetObjectEndpoint.GetAsync(id);
        }
    }
}