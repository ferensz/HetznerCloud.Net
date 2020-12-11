using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Core
{
    public class Pagination
    {
        public int Page { get; set; }
        
        [JsonPropertyName("per_page")]
        public int PageSize { get; set; }
        
        [JsonPropertyName("previous_page")]
        public int? PreviousPage { get; set; }
        
        [JsonPropertyName("next_page")]
        public int? NextPage { get; set; }
        
        [JsonPropertyName("last_page")]
        public int LastPage { get; set; }
        
        [JsonPropertyName("total_entries")]
        public int TotalEntries { get; set; }
    }
}