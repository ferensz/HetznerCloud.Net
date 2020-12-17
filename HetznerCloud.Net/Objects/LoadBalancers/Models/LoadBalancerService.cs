using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class LoadBalancerService
    {
        /// <summary>
        /// Protocol of the Load Balancer
        /// </summary>
        [JsonPropertyName("protocol")] public LoadBalancerServiceProtocols Protocol { get; set; }

        /// <summary>
        /// Port the Load Balancer listens on
        /// </summary>
        [JsonPropertyName("listen_port")] public int ListenPort { get; set; }

        /// <summary>
        /// Port the Load Balancer will balance to
        /// </summary>
        [JsonPropertyName("destination_port")] public int DestinationPort { get; set; }

        /// <summary>
        /// Is Proxyprotocol enabled or not
        /// </summary>
        [JsonPropertyName("proxyprotocol")] public bool ProxyProtocol { get; set; }

        /// <summary>
        /// Health check that belong to this service
        /// </summary>
        [JsonPropertyName("health_check")] public LoadBalancerServiceHealthCheck HealthCheck { get; set; }

        /// <summary>
        /// Configuration option for protocols http and https
        /// </summary>
        [JsonPropertyName("http")] public ServiceHttpConfiguration HttpConfiguration { get; set; }
    }
}