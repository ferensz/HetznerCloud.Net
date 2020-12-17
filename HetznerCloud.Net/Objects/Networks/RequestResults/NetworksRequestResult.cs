using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Networks.Models;

namespace HetznerCloud.Net.Objects.Networks.RequestResults
{
    public class NetworksRequestResult : MultipleObjectsResultBase<Network>
    {
        [JsonPropertyName("networks")]
        public override List<Network> Data { get; set; }
    }
}