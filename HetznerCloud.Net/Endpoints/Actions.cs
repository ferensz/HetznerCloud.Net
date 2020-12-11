using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Objects.Actions;

namespace HetznerCloud.Net.Endpoints
{
    public class Actions : BaseEndpoint
    {
        public Actions(string apiToken) : base(apiToken)
        {
        }
        
        public async Task<Action> GetActionAsync(long id)
        {
            var res = await SendRequest($"/actions/{id}");
            var actionResult = JsonSerializer.Deserialize<SingleActionRequestResult>(res, Settings.JsonSerializerOptions);

            return actionResult.Action;
        }
        
        public async Task<List<Action>> GetAllActionsAsync()
        {
            List<Action> resultActions = new List<Action>();
             
            var res = await SendRequest("/actions");
            var actionsPage = JsonSerializer.Deserialize<ActionsRequestResult>(res, Settings.JsonSerializerOptions);

            if (actionsPage != null)
            {
                var lastPage = actionsPage.Meta.Pagination.LastPage;
                
                resultActions.AddRange(actionsPage.Actions);

                while (actionsPage.Meta.Pagination.Page < lastPage)
                {
                    res = await SendRequest("/actions");
                    actionsPage = JsonSerializer.Deserialize<ActionsRequestResult>(res, Settings.JsonSerializerOptions);
                    
                    resultActions.AddRange(actionsPage.Actions);
                }
            }

            return resultActions;
        }
    }
}