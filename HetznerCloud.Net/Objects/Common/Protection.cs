using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Common
{
    public class Protection
    {
        /// <summary>
        /// If true, prevents the object from being deleted
        /// </summary>
        [JsonPropertyName("delete")] public bool Delete { get; set; }
    }
}