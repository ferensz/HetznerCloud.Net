using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Certificates.Models;

namespace HetznerCloud.Net.Objects.Certificates.RequestResults
{
    public class SingleCertificateRequestResult : SingleObjectResultBase<Certificate>
    {
        [JsonPropertyName("certificate")] 
        public override Certificate Data { get; set; }
    }
}