using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.FloatingIps
{
    public class SingleFloatingIpRequestResult : SingleObjectResultBase<FloatingIp>
    {
        [JsonPropertyName("floating_ip")] 
        public override FloatingIp Data { get; set; }
    }
}