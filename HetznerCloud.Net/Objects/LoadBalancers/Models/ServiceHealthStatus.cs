using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class ServiceHealthStatus
    {
        [JsonPropertyName("listen_port")] public int ListenPort { get; set; }
        [JsonPropertyName("status")] public string Status { get; set; }
    }
}