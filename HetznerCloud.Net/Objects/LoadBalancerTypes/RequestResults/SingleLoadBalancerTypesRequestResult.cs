using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Common;

namespace HetznerCloud.Net.Objects.LoadBalancerTypes.RequestResults
{
    public class SingleLoadBalancerTypesRequestResult : SingleObjectResultBase<LoadBalancerType>
    {
        [JsonPropertyName("load_balancer_types")]
        public override LoadBalancerType Data { get; set; }
    }
}