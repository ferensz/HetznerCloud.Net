using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Datacenters.Models;

namespace HetznerCloud.Net.Objects.Datacenters.RequestResults
{
    public class SingleDatacenterRequestResult : SingleObjectResultBase<Datacenter>
    {
        [JsonPropertyName("datacenter")]
        public override Datacenter Data { get; set; }
    }
}