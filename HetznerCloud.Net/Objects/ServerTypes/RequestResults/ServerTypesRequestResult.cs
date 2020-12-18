using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Common;

namespace HetznerCloud.Net.Objects.ServerTypes.RequestResults
{
    public class ServerTypesRequestResult : MultipleObjectsResultBase<ServerType>
    {
        [JsonPropertyName("server_types")]
        public override List<ServerType> Data { get; set; }
    }
}