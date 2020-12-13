using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.FloatingIps.Models
{
    public class Protection
    {
        [JsonPropertyName("delete")]
        public bool Delete { get; set; }
    }
}