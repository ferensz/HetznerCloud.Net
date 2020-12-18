using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Pricing.RequestResults
{
    public class SinglePricingRequestResult : SingleObjectResultBase<Models.Pricing>
    {
        [JsonPropertyName("pricing")]
        public override Models.Pricing Data { get; set; }
    }
}