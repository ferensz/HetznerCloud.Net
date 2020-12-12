using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Core.Requests;

namespace HetznerCloud.Net.Objects.FloatingIps
{
    public class FloatingIpsRequestResult : MultipleObjectsResultBase<FloatingIp>
    {
        [JsonPropertyName("floating_ips")]
        public override List<FloatingIp> Data { get; set; } 
    }
}