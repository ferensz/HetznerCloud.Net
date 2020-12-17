﻿using System.Net;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class PrivateNetwork
    {
        [JsonPropertyName("network")] public long Network { get; set; }

        [JsonPropertyName("ip")] public IPAddress Ip { get; set; }
    }
}