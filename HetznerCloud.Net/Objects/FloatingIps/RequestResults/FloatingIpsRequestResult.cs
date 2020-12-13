using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Core.Requests;
using HetznerCloud.Net.Objects.FloatingIps.Models;

namespace HetznerCloud.Net.Objects.FloatingIps.RequestResults
{
    public class FloatingIpsRequestResult : MultipleObjectsResultBase<FloatingIp>
    {
        [JsonPropertyName("floating_ips")]
        public override List<FloatingIp> Data { get; set; } 
    }
}