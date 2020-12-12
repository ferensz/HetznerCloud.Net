using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Datacenters
{
    public class SingleDatacenterRequestResult : SingleObjectResultBase<Datacenter>
    {
        [JsonPropertyName("datacenter")]
        public override Datacenter Data { get; set; }
    }
}