using System.Net;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Servers.Models
{
    public class ServerIpv4
    {
        [JsonPropertyName("ip")]
        public string Ip { get; set; } 

        [JsonPropertyName("blocked")]
        public bool Blocked { get; set; } 

        [JsonPropertyName("dns_ptr")]
        public string DnsPtr { get; set; }
    }
}