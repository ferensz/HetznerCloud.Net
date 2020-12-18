using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Networks.Models
{
    public class Subnet
    {
        /// <summary>
        /// Type of Subnetwork
        /// </summary>
        [JsonPropertyName("type")]
        public SubnetTypes Type { get; set; } 

        /// <summary>
        /// Range to allocate IPs from.
        /// Must be a Subnet of the ip_range of the parent network object and must not overlap with any other subnets
        /// or with any destinations in routes.
        /// Minimum Network size is /30. Hetzner suggest that you pick a bigger Network with a /24 netmask.
        /// </summary>
        [JsonPropertyName("ip_range")]
        public string IpRange { get; set; } 

        /// <summary>
        /// Name of Network zone. Currently eu-central is the only available zone.
        /// </summary>
        [JsonPropertyName("network_zone")]
        public string NetworkZone { get; set; } 

        /// <summary>
        /// Gateway for Servers attached to this subnet.
        /// For subnets of type Server this is always the first IP of the network IP range.
        /// </summary>
        [JsonPropertyName("gateway")]
        public string Gateway { get; set; }
    }
}