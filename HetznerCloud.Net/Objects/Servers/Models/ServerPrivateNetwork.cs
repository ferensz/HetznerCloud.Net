using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Servers.Models
{
    public class ServerPrivateNetwork
    {
        [JsonPropertyName("network")]
        public int Network { get; set; } 

        [JsonPropertyName("ip")]
        public string Ip { get; set; } 

        [JsonPropertyName("alias_ips")]
        public List<string> AliasIps { get; set; } 

        [JsonPropertyName("mac_address")]
        public string MacAddress { get; set; }
    }
}