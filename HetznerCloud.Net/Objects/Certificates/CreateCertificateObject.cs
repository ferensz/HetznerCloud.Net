using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Certificates
{
    public class CreateCertificateObject : CreateObjectBase
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; }
        
        [JsonPropertyName("certificate")]
        public string Certificate { get; set; }
        
        [JsonPropertyName("private_key")]
        public string PrivateKey { get; set; }

        public override void ValidateObject()
        {
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentException("Name cannot be empty", "Name");
            
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentException("Certificate cannot be empty", "Certificate");
            
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentException("PrivateKey cannot be empty", "PrivateKey");
        }
    }
}