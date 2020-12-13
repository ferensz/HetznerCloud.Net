using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Certificates.Models
{
    public class UsedBy
    {
        [JsonPropertyName("id")] 
        public int Id { get; set; }

        [JsonPropertyName("type")] 
        public string Type { get; set; }
    }
}