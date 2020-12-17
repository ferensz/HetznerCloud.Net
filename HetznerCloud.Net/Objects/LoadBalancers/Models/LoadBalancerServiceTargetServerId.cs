using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class LoadBalancerServiceTargetServerId
    {
        [JsonPropertyName("id")] public long Id { get; set; }
    }
}