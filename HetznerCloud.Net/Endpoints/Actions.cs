using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Objects;
using HetznerCloud.Net.Objects.Actions;
using HetznerCloud.Net.Objects.Actions.Models;
using HetznerCloud.Net.Objects.Actions.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Actions : BaseEndpoint<SingleActionRequestResult, ActionsRequestResult, Action>
    {
        private const string _endpointPath = "/actions";
        
        public Actions(string apiToken) : base(apiToken, _endpointPath)
        {
        }
    }
}