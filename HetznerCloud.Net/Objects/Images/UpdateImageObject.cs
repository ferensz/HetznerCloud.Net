using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Images.Models;

namespace HetznerCloud.Net.Objects.Images
{
    public class UpdateImageObject : UpdateObjectBase
    {
        [JsonPropertyName("description")]
        public string Description { get; set; } 

        [JsonPropertyName("type")]
        public ImageTypes Type { get; set; } 

        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; }
    }
}