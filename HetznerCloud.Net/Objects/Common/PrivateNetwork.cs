using System.Net;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Common
{
    public class PrivateNetwork
    {
        [JsonPropertyName("network")] public long Network { get; set; }

        [JsonPropertyName("ip")] public IPAddress Ip { get; set; }
    }
}