using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Core;
using HetznerCloud.Net.Core.Requests;

namespace HetznerCloud.Net.Objects.Datacenters
{
    public class DatacentersRequestResult : MultipleObjectsResultBase<Datacenter>
    {
        [JsonPropertyName("datacenters")]
        public override List<Datacenter> Data { get; set; } 

        [JsonPropertyName("recommendation")]
        public int Recommendation { get; set; }
    }
}