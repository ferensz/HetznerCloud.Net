using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.FloatingIps;

namespace HetznerCloud.Net.Objects.Images.Models
{
    public class Image
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("type")]
        public ImageTypes Type { get; set; } 

        [JsonPropertyName("status")]
        public ImageStatuses Status { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; } 

        [JsonPropertyName("description")]
        public string Description { get; set; } 

        [JsonPropertyName("image_size")]
        public double? ImageSize { get; set; } 

        [JsonPropertyName("disk_size")]
        public double? DiskSize { get; set; } 

        [JsonPropertyName("created")]
        public DateTime Created { get; set; } 

        [JsonPropertyName("created_from")]
        public CreatedFrom CreatedFrom { get; set; } 

        [JsonPropertyName("bound_to")]
        public object BoundTo { get; set; } 

        [JsonPropertyName("os_flavor")]
        public string OsFlavor { get; set; } 

        [JsonPropertyName("os_version")]
        public string OsVersion { get; set; } 

        [JsonPropertyName("rapid_deploy")]
        public bool RapidDeploy { get; set; } 

        [JsonPropertyName("protection")]
        public ImageProtection Protection { get; set; }

        [JsonPropertyName("deprecated")]
        public DateTime? Deprecated { get; set; } 

        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; }
    }
}