using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Common;

namespace HetznerCloud.Net.Objects.Pricing.Models
{
    public class ServerTypes
    {
        [JsonPropertyName("id")]
        public long Id { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("prices")]
        public List<LocationPrice> Prices { get; set; }
    }
}