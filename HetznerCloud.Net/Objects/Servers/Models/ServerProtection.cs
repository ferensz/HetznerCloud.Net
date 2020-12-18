using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Servers.Models
{
    public class ServerProtection
    {
        [JsonPropertyName("delete")]
        public bool Delete { get; set; } 

        [JsonPropertyName("rebuild")]
        public bool Rebuild { get; set; }
    }
}