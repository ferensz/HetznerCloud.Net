using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Datacenters
{
    public class ServerTypes    
    {
        [JsonPropertyName("supported")]
        public List<int> Supported { get; set; } 

        [JsonPropertyName("available")]
        public List<int> Available { get; set; } 

        [JsonPropertyName("available_for_migration")]
        public List<int> AvailableForMigration { get; set; } 
    }
}