using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Common;

namespace HetznerCloud.Net.Objects.Common
{
    public class LoadBalancerType
    {
        /// <summary>
        /// ID of the Load Balancer type
        /// </summary>
        [JsonPropertyName("id")] public long Id { get; set; }

        /// <summary>
        /// Unique identifier of the Load Balancer type
        /// </summary>
        [JsonPropertyName("name")] public string Name { get; set; }

        /// <summary>
        /// Description of the Load Balancer type
        /// </summary>
        [JsonPropertyName("description")] public string Description { get; set; }

        /// <summary>
        /// Number of maximum simultaneous open connections
        /// </summary>
        [JsonPropertyName("max_connections")] public int MaxConnections { get; set; }

        /// <summary>
        /// Number of services a Load Balancer of this type can have
        /// </summary>
        [JsonPropertyName("max_services")] public int MaxServices { get; set; }

        /// <summary>
        /// Number of targets a single Load Balancer can have
        /// </summary>
        [JsonPropertyName("max_targets")] public int MaxTargets { get; set; }
        
        /// <summary>
        /// Number of SSL Certificates that can be assigned to a single Load Balancer
        /// </summary>
        [JsonPropertyName("max_assigned_certificates")]
        public int MaxAssignedCertificates { get; set; }

        /// <summary>
        /// Point in time when the Load Balancer type is deprecated (in ISO-8601 format)
        /// </summary>
        [JsonPropertyName("deprecated")] public DateTime? Deprecated { get; set; }

        /// <summary>
        /// Prices in different network zones
        /// </summary>
        [JsonPropertyName("prices")] public List<LocationPrice> Prices { get; set; }
    }
}