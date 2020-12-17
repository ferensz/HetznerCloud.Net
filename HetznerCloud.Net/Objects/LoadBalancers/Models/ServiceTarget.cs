using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class ServiceTarget
    {
        /// <summary>
        /// Type of the resource
        /// </summary>
        [JsonPropertyName("type")] public string Type { get; set; }

        /// <summary>
        /// Server where the traffic should be routed through
        /// </summary>
        [JsonPropertyName("server")] public LoadBalancerServiceTargetServerId Server { get; set; }

        /// <summary>
        /// List of health statuses of the services on this target
        /// </summary>
        [JsonPropertyName("health_status")] public List<ServiceHealthStatus> HealthStatus { get; set; }

        /// <summary>
        /// Use the private network IP instead of the public IP. Default value is false.
        /// </summary>
        [JsonPropertyName("use_private_ip")] public bool UsePrivateIp { get; set; }

        /// <summary>
        /// Label selector and a list of selected targets
        /// </summary>
        [JsonPropertyName("label_selector")] public ServiceLabelSelector LabelSelector { get; set; }

        /// <summary>
        /// IP targets where the traffic should be routed through.
        /// Currently it is only possible to use the IPs of Hetzner Online Root Servers belonging to the project owner.
        /// IPs belonging to other users are blocked.
        /// Additionally IPs belonging to services provided by Hetzner Cloud (Servers, Load Balancers, ...) are blocked as well.
        /// </summary>
        [JsonPropertyName("ip")] public ServiceTargetIp Ip { get; set; }

        /// <summary>
        /// List of selected targets
        /// </summary>
        [JsonPropertyName("targets")] public List<SelectedServiceTarget> Targets { get; set; }
    }
}