using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class ServiceLabelSelector
    {
        /// <summary>
        /// Label selector
        /// </summary>
        [JsonPropertyName("selector")] public string Selector { get; set; }
    }
}