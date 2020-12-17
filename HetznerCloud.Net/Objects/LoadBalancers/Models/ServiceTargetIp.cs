using System.Net;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class ServiceTargetIp
    {
        /// <summary>
        /// IP of a server that belongs to the same customer (public IPv4/IPv6).
        /// </summary>
        [JsonPropertyName("ip")] public IPAddress IpAddress { get; set; }
    }
}