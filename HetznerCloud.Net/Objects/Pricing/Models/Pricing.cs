using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Pricing.Models
{
    public class Pricing
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; } 

        [JsonPropertyName("vat_rate")]
        public double VatRate { get; set; }
    }
}