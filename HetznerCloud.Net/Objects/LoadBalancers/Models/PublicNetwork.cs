using System.Net;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class PublicNetwork
    {
        /// <summary>
        /// Public Interface enabled or not
        /// </summary>
        [JsonPropertyName("enabled")] public bool Enabled { get; set; }

        /// <summary>
        /// IP address (v4)
        /// </summary>
        [JsonPropertyName("ipv4")] public Ipv4 Ipv4 { get; set; }

        /// <summary>
        /// IP address (v6)
        /// </summary>
        [JsonPropertyName("ipv6")] public Ipv6 Ipv6 { get; set; }
    }
    
    public class Ipv4
    {
        /// <summary>
        /// IP address (v4) of this Load Balancer
        /// </summary>
        [JsonPropertyName("ip")] public IPAddress IpAddress { get; set; }
    }

    public class Ipv6
    {
        /// <summary>
        /// IP address (v6) of this Load Balancer
        /// </summary>
        [JsonPropertyName("ip")] public IPAddress IpAddress { get; set; }
    }
}