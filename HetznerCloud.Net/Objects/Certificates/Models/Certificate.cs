using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Certificates.Models
{
    public class Certificate
    {
        [JsonPropertyName("id")] 
        public long Id { get; set; }

        [JsonPropertyName("name")] 
        public string Name { get; set; }

        [JsonPropertyName("labels")] 
        public Dictionary<string, string> Labels { get; set; }

        [JsonPropertyName("certificate")] 
        public string CertificateData { get; set; }

        [JsonPropertyName("created")] 
        public DateTime Created { get; set; }

        [JsonPropertyName("not_valid_before")] 
        public DateTime NotValidBefore { get; set; }

        [JsonPropertyName("not_valid_after")] 
        public DateTime NotValidAfter { get; set; }

        [JsonPropertyName("domain_names")] 
        public List<string> DomainNames { get; set; }

        [JsonPropertyName("fingerprint")] 
        public string Fingerprint { get; set; }

        [JsonPropertyName("used_by")] 
        public List<UsedBy> UsedBy { get; set; }
    }
}