using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Datacenters
{
    public class Location    
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("description")]
        public string Description { get; set; } 

        [JsonPropertyName("country")]
        public string Country { get; set; } 

        [JsonPropertyName("city")]
        public string City { get; set; } 

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; } 

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; } 

        [JsonPropertyName("network_zone")]
        public string NetworkZone { get; set; } 
    }
}