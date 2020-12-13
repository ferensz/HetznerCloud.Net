using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.FloatingIps.Models
{
    public class FloatingIp
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("description")]
        public string Description { get; set; } 

        [JsonPropertyName("ip")]
        public string Ip { get; set; } 

        [JsonPropertyName("type")]
        public string Type { get; set; } 

        [JsonPropertyName("server")]
        public int Server { get; set; } 

        [JsonPropertyName("dns_ptr")]
        public List<DnsPtr> DnsPtr { get; set; } 

        [JsonPropertyName("home_location")]
        public HomeLocation HomeLocation { get; set; } 

        [JsonPropertyName("blocked")]
        public bool Blocked { get; set; } 

        [JsonPropertyName("protection")]
        public Protection Protection { get; set; } 

        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; } 

        [JsonPropertyName("created")]
        public DateTime Created { get; set; }
    }
}