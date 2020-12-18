using System.Text.Json.Serialization;
using HetznerCloud.Net.Helpers;

namespace HetznerCloud.Net.Objects.Common
{
    public class Price
    {
        /// <summary>
        /// Price without VAT
        /// </summary>
        [JsonPropertyName("net")]
        [JsonConverter(typeof(JsonStringToDecimalConverter))]
        public decimal Net { get; set; }

        /// <summary>
        /// Price with VAT
        /// </summary>
        [JsonPropertyName("gross")]
        [JsonConverter(typeof(JsonStringToDecimalConverter))]
        public decimal Gross { get; set; }
    }
}