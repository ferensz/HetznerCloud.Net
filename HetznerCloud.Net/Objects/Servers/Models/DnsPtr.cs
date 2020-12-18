using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Servers.Models
{
    public class DnsPtr
    {
        [JsonPropertyName("ip")] public string Ip { get; set; }

        [JsonPropertyName("dns_ptr")] public string ReverseDns { get; set; }
    }
}