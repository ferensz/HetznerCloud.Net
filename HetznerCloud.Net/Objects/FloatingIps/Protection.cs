using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.FloatingIps
{
    public class Protection
    {
        [JsonPropertyName("delete")]
        public bool Delete { get; set; }
    }
}