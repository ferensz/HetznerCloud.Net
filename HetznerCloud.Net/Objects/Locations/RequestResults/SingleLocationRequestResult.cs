using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Locations.Models;

namespace HetznerCloud.Net.Objects.Locations.RequestResults
{
    public class SingleLocationRequestResult : SingleObjectResultBase<Location>
    {
        [JsonPropertyName("location")]
        public override Location Data { get; set; }
    }
}