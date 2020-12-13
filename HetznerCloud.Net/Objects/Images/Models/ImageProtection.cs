using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Images.Models
{
    public class ImageProtection
    {
        [JsonPropertyName("delete")]
        public bool Delete { get; set; }
    }
}