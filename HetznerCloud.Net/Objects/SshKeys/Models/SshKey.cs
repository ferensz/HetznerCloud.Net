using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.SshKeys.Models
{
    public class SshKey
    {
        [JsonPropertyName("id")]
        public long Id { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; } 

        [JsonPropertyName("public_key")]
        public string PublicKey { get; set; } 

        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; } 

        [JsonPropertyName("created")]
        public DateTime Created { get; set; }
    }
}