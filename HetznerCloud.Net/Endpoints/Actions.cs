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
    public class Actions : IGetObject<Action>, IGetAllObjects<Action>
    {
        private const string EndpointPath = "/actions";

        private readonly EndpointService<SingleActionRequestResult, ActionsRequestResult, Action> _endpointService;
        
        public Actions(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleActionRequestResult, ActionsRequestResult, Action>(apiToken, EndpointPath);
        }

        public async Task<Action> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<Action>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }
    }
}