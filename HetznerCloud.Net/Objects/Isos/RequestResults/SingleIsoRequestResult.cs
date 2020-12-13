using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Isos.Models;

namespace HetznerCloud.Net.Objects.Isos.RequestResults
{
    public class SingleIsoRequestResult : SingleObjectResultBase<Iso>
    {
        [JsonPropertyName("iso")]
        public override Iso Data { get; set; }
    }
}