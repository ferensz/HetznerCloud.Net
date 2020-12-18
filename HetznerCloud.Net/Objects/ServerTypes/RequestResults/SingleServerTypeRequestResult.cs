using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Common;

namespace HetznerCloud.Net.Objects.ServerTypes.RequestResults
{
    public class SingleServerTypeRequestResult : SingleObjectResultBase<ServerType>
    {
        [JsonPropertyName("server_type")]
        public override ServerType Data { get; set; }
    }
}