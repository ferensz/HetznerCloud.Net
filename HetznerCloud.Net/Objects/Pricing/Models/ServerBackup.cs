using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Pricing.Models
{
    public class ServerBackup
    {
        [JsonPropertyName("percentage")]
        public double Percentage { get; set; } 
    }
}