using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Certificates
{
    public class UpdateCertificateObject : UpdateObjectBase
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; }
    }
}