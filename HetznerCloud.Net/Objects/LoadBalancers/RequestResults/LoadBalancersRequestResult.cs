using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.LoadBalancers.Models;

namespace HetznerCloud.Net.Objects.LoadBalancers.RequestResults
{
    public class LoadBalancersRequestResult : MultipleObjectsResultBase<LoadBalancer>
    {
        [JsonPropertyName("load_balancers")]
        public override List<LoadBalancer> Data { get; set; }
    }
}