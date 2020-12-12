using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Actions
{
    public class SingleActionRequestResult : SingleObjectResultBase<Action>
    {
        [JsonPropertyName("action")]
        public override Action Data { get; set; }
    }
}