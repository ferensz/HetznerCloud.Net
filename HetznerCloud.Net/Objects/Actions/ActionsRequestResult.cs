using System.Collections.Generic;
using HetznerCloud.Net.Core;

namespace HetznerCloud.Net.Objects.Actions
{
    public class ActionsRequestResult
    {
        public List<Action> Actions { get; set; }
        
        public Meta Meta { get; set; }
    }
}