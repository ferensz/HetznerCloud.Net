using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Common
{
    public class Price
    {
        /// <summary>
        /// Price without VAT
        /// </summary>
        [JsonPropertyName("net")] public double Net { get; set; }

        /// <summary>
        /// Price with VAT
        /// </summary>
        [JsonPropertyName("gross")] public double Gross { get; set; }
    }
}