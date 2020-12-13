using System;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Isos.Models
{
    public class Iso
    {
        [JsonPropertyName("id")]
        public long Id { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("description")]
        public string Description { get; set; } 

        [JsonPropertyName("type")]
        public IsoTypes Type { get; set; } 

        [JsonPropertyName("deprecated")]
        public DateTime? Deprecated { get; set; }
    }
}