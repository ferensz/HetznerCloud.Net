using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.Certificates
{
    public class SingleCertificateRequestResult : SingleObjectResultBase<Certificate>
    {
        [JsonPropertyName("certificate")] 
        public override Certificate Data { get; set; }
    }
}