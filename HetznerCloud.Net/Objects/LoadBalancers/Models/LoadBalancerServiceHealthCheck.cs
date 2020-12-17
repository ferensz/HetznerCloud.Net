using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class LoadBalancerServiceHealthCheck
    {
        /// <summary>
        /// Type of the health check
        /// </summary>
        [JsonPropertyName("protocol")] public LoadBalancerHealthCheckProtocols Protocol { get; set; }

        /// <summary>
        /// Port the health check will be performed on
        /// </summary>
        [JsonPropertyName("port")] public int Port { get; set; }

        /// <summary>
        /// Time interval in seconds health checks are performed
        /// </summary>
        [JsonPropertyName("interval")] public int Interval { get; set; }

        /// <summary>
        /// Time in seconds after an attempt is considered a timeout
        /// </summary>
        [JsonPropertyName("timeout")] public int Timeout { get; set; }

        /// <summary>
        /// Unsuccessful retries needed until a target is considered unhealthy
        /// </summary>
        [JsonPropertyName("retries")] public int Retries { get; set; }

        /// <summary>
        /// Additional configuration for protocol http
        /// </summary>
        [JsonPropertyName("http")] public HealthCheckHttpConfiguration HttpConfiguration { get; set; }
    }
}