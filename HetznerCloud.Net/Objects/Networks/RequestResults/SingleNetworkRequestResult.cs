using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Networks.Models;

namespace HetznerCloud.Net.Objects.Networks.RequestResults
{
    public class SingleNetworkRequestResult : SingleObjectResultBase<Network>
    {
        [JsonPropertyName("network")]
        public override Network Data { get; set; }
    }
}