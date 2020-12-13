using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Images.Models
{
    public class CreatedFrom
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } 

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}