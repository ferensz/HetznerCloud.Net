using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Common;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class LoadBalancer
    {
        /// <summary>
        /// ID of the Load Balancer
        /// </summary>
        [JsonPropertyName("id")] public long Id { get; set; }

        /// <summary>
        /// Unique name of the Load Balancer
        /// </summary>
        [JsonPropertyName("name")] public string Name { get; set; }

        /// <summary>
        /// Public network information
        /// </summary>
        [JsonPropertyName("public_net")] public PublicNetwork PublicNet { get; set; }

        /// <summary>
        /// Private networks information
        /// </summary>
        [JsonPropertyName("private_net")] public List<PrivateNetwork> PrivateNet { get; set; }

        /// <summary>
        /// Location of the Load Balancer
        /// </summary>
        [JsonPropertyName("location")] public Location Location { get; set; }

        /// <summary>
        /// Type of the Load Balancer
        /// </summary>
        [JsonPropertyName("load_balancer_type")]
        public LoadBalancerType LoadBalancerType { get; set; }

        /// <summary>
        /// Protection configuration for the Load Balancer
        /// </summary>
        [JsonPropertyName("protection")] public Protection Protection { get; set; }

        /// <summary>
        /// User-defined labels (key-value pairs)
        /// </summary>
        [JsonPropertyName("labels")] public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Point in time when the Load Balancer was created (in ISO-8601 format)
        /// </summary>
        [JsonPropertyName("created")] public DateTime Created { get; set; }

        /// <summary>
        /// List of services that belong to this Load Balancer
        /// </summary>
        [JsonPropertyName("services")] public List<LoadBalancerService> Services { get; set; }

        /// <summary>
        /// List of targets that belong to this Load Balancer
        /// </summary>
        [JsonPropertyName("targets")] public List<ServiceTarget> Targets { get; set; }

        /// <summary>
        /// Algorithm of the Load Balancer
        /// </summary>
        [JsonPropertyName("algorithm")] public LoadBalancerAlgorithm Algorithm { get; set; }

        /// <summary>
        /// Outbound Traffic for the current billing period in bytes
        /// </summary>
        [JsonPropertyName("outgoing_traffic")] public int? OutgoingTraffic { get; set; }

        /// <summary>
        /// Inbound Traffic for the current billing period in bytes
        /// </summary>
        [JsonPropertyName("ingoing_traffic")] public int? IngoingTraffic { get; set; }

        /// <summary>
        /// Free Traffic for the current billing period in bytes
        /// </summary>
        [JsonPropertyName("included_traffic")] public int IncludedTraffic { get; set; }
    }
}