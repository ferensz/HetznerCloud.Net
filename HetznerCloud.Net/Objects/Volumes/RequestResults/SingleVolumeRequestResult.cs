using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Volumes.Models;

namespace HetznerCloud.Net.Objects.Volumes.RequestResults
{
    public class SingleVolumeRequestResult : SingleObjectResultBase<Volume>
    {
        [JsonPropertyName("volume")]
        public override Volume Data { get; set; }
    }
}