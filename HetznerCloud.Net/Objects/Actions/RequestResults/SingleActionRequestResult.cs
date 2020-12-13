using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Actions.Models;

namespace HetznerCloud.Net.Objects.Actions.RequestResults
{
    public class SingleActionRequestResult : SingleObjectResultBase<Action>
    {
        [JsonPropertyName("action")]
        public override Action Data { get; set; }
    }
}