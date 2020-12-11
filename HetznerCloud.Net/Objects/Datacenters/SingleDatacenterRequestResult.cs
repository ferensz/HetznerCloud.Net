using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Datacenters
{
    public class SingleDatacenterRequestResult
    {
        [JsonPropertyName("datacenter")]
        public Datacenter Datacenter { get; set; }
    }
}