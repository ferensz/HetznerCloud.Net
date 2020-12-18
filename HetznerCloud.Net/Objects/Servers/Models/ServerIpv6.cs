using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Servers.Models
{
    public class ServerIpv6
    {
        [JsonPropertyName("ip")]
        public string Ip { get; set; } 

        [JsonPropertyName("blocked")]
        public bool Blocked { get; set; } 

        [JsonPropertyName("dns_ptr")]
        public List<DnsPtr> DnsPtr { get; set; }
    }
}