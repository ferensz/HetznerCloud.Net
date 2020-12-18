using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Servers.Models;

namespace HetznerCloud.Net.Objects.Servers.RequestResults
{
    public class ServersRequestResult : MultipleObjectsResultBase<Server>
    {
        [JsonPropertyName("servers")]
        public override List<Server> Data { get; set; }
    }
}