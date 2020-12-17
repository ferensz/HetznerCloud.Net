﻿using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Networks.Models
{
    public class Route
    {
        /// <summary>
        /// Destination network or host of this route.
        /// Must not overlap with an existing ip_range in any subnets or with any destinations in other routes
        /// or with the first IP of the networks ip_range or with 172.31.1.1.
        /// Must be one of the private IPv4 ranges of RFC1918.
        /// </summary>
        [JsonPropertyName("destination")]
        public string Destination { get; set; } 

        /// <summary>
        /// Gateway for the route.
        /// Cannot be the first IP of the networks ip_range and also cannot be 172.31.1.1 as this IP is being used
        /// as a gateway for the public network interface of Servers.
        /// </summary>
        [JsonPropertyName("gateway")]
        public string Gateway { get; set; }
    }
}