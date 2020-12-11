using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Core;

namespace HetznerCloud.Net.Objects.Datacenters
{
    public class DatacentersRequestResult
    {
        [JsonPropertyName("datacenters")]
        public List<Datacenter> Datacenters { get; set; } 

        [JsonPropertyName("recommendation")]
        public int Recommendation { get; set; } 

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}