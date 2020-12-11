using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Certificates
{
    public class CreateCertificateObject
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; }
        
        [JsonPropertyName("certificate")]
        public string Certificate { get; set; }
        
        [JsonPropertyName("private_key")]
        public string PrivateKey { get; set; }
    }
}