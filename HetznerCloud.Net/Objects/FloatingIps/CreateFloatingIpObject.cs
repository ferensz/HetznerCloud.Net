using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.FloatingIps.Models;

namespace HetznerCloud.Net.Objects.FloatingIps
{
    public class CreateFloatingIpObject : CreateObjectBase
    {
        [JsonPropertyName("type")]
        public FloatingIpTypes Type { get; set; } 

        [JsonPropertyName("server")]
        public long ServerId { get; set; } 

        [JsonPropertyName("home_location")]
        public string HomeLocationName { get; set; } 

        [JsonPropertyName("description")]
        public string Description { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; } 
        
        public override void ValidateObject()
        {
            if (Type.Equals(FloatingIpTypes.Undefined))
                throw new ArgumentException("Floating IP type must be defined", "Type");
            
            if (ServerId == 0 && string.IsNullOrEmpty(HomeLocationName))
                throw new ArgumentException("Either server id or home location name must be set");
        }
    }
}