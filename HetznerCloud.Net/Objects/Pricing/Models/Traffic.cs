using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Common;

namespace HetznerCloud.Net.Objects.Pricing.Models
{
    public class Traffic
    {
        [JsonPropertyName("price_per_tb")]
        public Price PricePerTb { get; set; }
    }
}