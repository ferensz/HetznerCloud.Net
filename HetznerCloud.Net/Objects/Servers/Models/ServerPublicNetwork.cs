using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Servers.Models
{
    public class ServerPublicNetwork
    {
        [JsonPropertyName("ipv4")]
        public ServerIpv4 Ipv4 { get; set; } 

        [JsonPropertyName("ipv6")]
        public ServerIpv6 Ipv6 { get; set; } 

        [JsonPropertyName("floating_ips")]
        public List<int> FloatingIps { get; set; }
    }
}