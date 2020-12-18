using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Common;

namespace HetznerCloud.Net.Objects.Networks.Models
{
    public class Network
    {
        /// <summary>
        /// ID of the Network
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; } 

        /// <summary>
        /// Name of the Network
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } 

        /// <summary>
        /// IPv4 prefix of the whole Network
        /// </summary>
        [JsonPropertyName("ip_range")]
        public string IpRange { get; set; } 

        /// <summary>
        /// Subnets allocated in this Network
        /// </summary>
        [JsonPropertyName("subnets")]
        public List<Subnet> Subnets { get; set; } 

        /// <summary>
        /// Routes set in this Network
        /// </summary>
        [JsonPropertyName("routes")]
        public List<Route> Routes { get; set; } 

        /// <summary>
        /// IDs of Servers attached to this Network
        /// </summary>
        [JsonPropertyName("servers")]
        public List<long> Servers { get; set; } 

        /// <summary>
        /// IDs of Load Balancers attached to this Network
        /// </summary>
        [JsonPropertyName("load_balancers")]
        public List<long> LoadBalancers { get; set; } 

        /// <summary>
        /// Protection configuration for the Network
        /// </summary>
        [JsonPropertyName("protection")]
        public Protection Protection { get; set; } 

        /// <summary>
        /// User-defined labels (key-value pairs)
        /// </summary>
        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; } 

        /// <summary>
        /// Point in time when the Network was created (in ISO-8601 format)
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }
    }
}