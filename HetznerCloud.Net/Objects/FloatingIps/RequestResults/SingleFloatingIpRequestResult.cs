using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.FloatingIps.Models;

namespace HetznerCloud.Net.Objects.FloatingIps.RequestResults
{
    public class SingleFloatingIpRequestResult : SingleObjectResultBase<FloatingIp>
    {
        [JsonPropertyName("floating_ip")] 
        public override FloatingIp Data { get; set; }
    }
}