using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Core;
using HetznerCloud.Net.Core.Requests;

namespace HetznerCloud.Net.Objects.Actions
{
    public class ActionsRequestResult : MultipleObjectsResultBase<Action>
    {
        [JsonPropertyName("actions")]
        public override List<Action> Data { get; set; }
    }
}