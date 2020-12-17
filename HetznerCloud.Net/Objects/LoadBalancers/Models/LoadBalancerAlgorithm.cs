using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class LoadBalancerAlgorithm
    {
        /// <summary>
        /// Type of the algorithm
        /// </summary>
        [JsonPropertyName("type")] public LoadBalancerAlgorithms Type { get; set; }
    }
}