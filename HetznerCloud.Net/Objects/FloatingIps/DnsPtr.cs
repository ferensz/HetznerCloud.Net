using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.FloatingIps
{
    public class DnsPtr
    {
        [JsonPropertyName("ip")]
        public string Ip { get; set; } 

        [JsonPropertyName("dns_ptr")]
        public string ReverseDnsPtr { get; set; }
    }
}