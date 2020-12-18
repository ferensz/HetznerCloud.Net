using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Common
{
    public class ServerType
    {
        /// <summary>
        /// ID of the Server type
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; } 

        /// <summary>
        /// Unique identifier of the Server type
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } 

        /// <summary>
        /// Description of the Server type
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } 

        /// <summary>
        /// Number of cpu cores a Server of this type will have
        /// </summary>
        [JsonPropertyName("cores")]
        public int Cores { get; set; } 

        /// <summary>
        /// Memory a Server of this type will have in GB
        /// </summary>
        [JsonPropertyName("memory")]
        public decimal Memory { get; set; } 

        /// <summary>
        /// Disk size a Server of this type will have in GB
        /// </summary>
        [JsonPropertyName("disk")]
        public int Disk { get; set; } 

        /// <summary>
        /// True if Server type is deprecated
        /// </summary>
        [JsonPropertyName("deprecated")]
        public bool? Deprecated { get; set; } 

        /// <summary>
        /// Prices in different Locations
        /// </summary>
        [JsonPropertyName("prices")]
        public List<LocationPrice> Prices { get; set; } 

        [JsonPropertyName("storage_type")]
        public StorageTypes StorageType { get; set; } 

        [JsonPropertyName("cpu_type")]
        public CpuTypes CpuType { get; set; }
    }
}