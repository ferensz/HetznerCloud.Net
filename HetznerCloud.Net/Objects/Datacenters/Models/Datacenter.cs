using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Datacenters.Models
{
    public class Datacenter
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("description")]
        public string Description { get; set; } 

        [JsonPropertyName("location")]
        public Location Location { get; set; } 

        [JsonPropertyName("server_types")]
        public ServerTypes ServerTypes { get; set; }
    }
}