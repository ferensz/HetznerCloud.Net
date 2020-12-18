using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Common;
using HetznerCloud.Net.Objects.Locations.Models;

namespace HetznerCloud.Net.Objects.Volumes.Models
{
    public class Volume
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("created")]
        public DateTime Created { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("server")]
        public int Server { get; set; } 

        [JsonPropertyName("location")]
        public Location Location { get; set; } 

        [JsonPropertyName("size")]
        public int Size { get; set; } 

        [JsonPropertyName("linux_device")]
        public string LinuxDevice { get; set; } 

        [JsonPropertyName("protection")]
        public Protection Protection { get; set; } 

        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; } 

        [JsonPropertyName("status")]
        public VolumeStatuses Status { get; set; } 

        [JsonPropertyName("format")]
        public string Format { get; set; }
    }
}