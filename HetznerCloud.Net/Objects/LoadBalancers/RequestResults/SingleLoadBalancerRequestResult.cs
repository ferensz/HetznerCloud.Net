using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.LoadBalancers.Models;

namespace HetznerCloud.Net.Objects.LoadBalancers.RequestResults
{
    public class SingleLoadBalancerRequestResult : SingleObjectResultBase<LoadBalancer>
    {
        [JsonPropertyName("load_balancer")]
        public override LoadBalancer Data { get; set; }
    }
}