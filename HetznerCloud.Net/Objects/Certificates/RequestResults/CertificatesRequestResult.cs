using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Core;
using HetznerCloud.Net.Core.Requests;
using HetznerCloud.Net.Objects.Certificates.Models;

namespace HetznerCloud.Net.Objects.Certificates.RequestResults
{
    public class CertificatesRequestResult : MultipleObjectsResultBase<Certificate>
    {
        [JsonPropertyName("certificates")]
        public override List<Certificate> Data { get; set; }
    }
}