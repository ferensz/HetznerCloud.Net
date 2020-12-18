using System.Text.Json.Serialization;
using HetznerCloud.Net.Helpers;

namespace HetznerCloud.Net.Objects.Locations.Models
{
    public class Location
    {
        /// <summary>
        /// ID of the Location
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; } 

        /// <summary>
        /// Unique identifier of the Location
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } 

        /// <summary>
        /// Description of the Location
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } 

        /// <summary>
        /// ISO 3166-1 alpha-2 code of the country the Location resides in
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; } 

        /// <summary>
        /// City the Location is closest to
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; } 

        /// <summary>
        /// Latitude of the city closest to the Location
        /// </summary>
        [JsonPropertyName("latitude")]
        // [JsonConverter(typeof(JsonStringToDecimalConverter))]
        public decimal Latitude { get; set; } 

        /// <summary>
        /// Longitude of the city closest to the Location
        /// </summary>
        [JsonPropertyName("longitude")]
        // [JsonConverter(typeof(JsonStringToDecimalConverter))]
        public decimal Longitude { get; set; } 

        /// <summary>
        /// Name of network zone this Location resides in
        /// </summary>
        [JsonPropertyName("network_zone")]
        public string NetworkZone { get; set; } 
    }
}