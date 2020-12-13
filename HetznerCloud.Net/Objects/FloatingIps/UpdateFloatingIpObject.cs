using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.FloatingIps
{
    public class UpdateFloatingIpObject : UpdateObjectBase
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("description")]
        public string Description { get; set; } 

        [JsonPropertyName("labels")]
        public Dictionary<string,string> Labels { get; set; }
    }
}