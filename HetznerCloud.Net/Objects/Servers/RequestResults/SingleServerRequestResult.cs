using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Servers.Models;

namespace HetznerCloud.Net.Objects.Servers.RequestResults
{
    public class SingleServerRequestResult : SingleObjectResultBase<Server>
    {
        [JsonPropertyName("server")]
        public override Server Data { get; set; }
    }
}