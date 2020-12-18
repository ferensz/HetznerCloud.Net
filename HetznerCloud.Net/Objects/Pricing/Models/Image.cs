using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Common;

namespace HetznerCloud.Net.Objects.Pricing.Models
{
    public class Image
    {
        [JsonPropertyName("price_per_gb_month")]
        public Price PricePerGbMonth { get; set; }
    }
}