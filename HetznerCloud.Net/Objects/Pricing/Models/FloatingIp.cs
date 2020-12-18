using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Common;

namespace HetznerCloud.Net.Objects.Pricing.Models
{
    public class FloatingIp
    {
        [JsonPropertyName("price_monthly")]
        public Price PriceMonthly { get; set; }
    }
}