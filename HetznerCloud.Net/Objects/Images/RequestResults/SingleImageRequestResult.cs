using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Images.Models;

namespace HetznerCloud.Net.Objects.Images.RequestResults
{
    public class SingleImageRequestResult : SingleObjectResultBase<Image>
    {
        [JsonPropertyName("image")]
        public override Image Data { get; set; }
    }
}