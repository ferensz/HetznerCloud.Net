using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.LoadBalancers.Models;

namespace HetznerCloud.Net.Objects.Common
{
    public class LocationPrice
    {
        /// <summary>
        /// Name of the Location the price is for
        /// </summary>
        [JsonPropertyName("location")] public string Location { get; set; }

        /// <summary>
        /// Hourly costs for a Resource in this Location
        /// </summary>
        [JsonPropertyName("price_hourly")] public Price PriceHourly { get; set; }

        /// <summary>
        /// Monthly costs for a Resource in this Location
        /// </summary>
        [JsonPropertyName("price_monthly")] public Price PriceMonthly { get; set; }
    }
}