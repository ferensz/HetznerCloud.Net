using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class SelectedServiceTarget
    {
        [JsonPropertyName("type")] public LoadBalancerServiceTargetTypes Type { get; set; }
        [JsonPropertyName("label_selector")] public ServiceLabelSelector LabelSelector { get; set; }
        [JsonPropertyName("server")] public LoadBalancerServiceTargetServerId Server { get; set; }
        [JsonPropertyName("health_status")] public List<ServiceHealthStatus> HealthStatus { get; set; }
    }
}