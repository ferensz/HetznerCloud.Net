using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Objects.Certificates;

namespace HetznerCloud.Net.Endpoints
{
    public class Certificates : BaseEndpoint<SingleCertificateRequestResult, CertificatesRequestResult, Certificate>
    {
        public Certificates(string apiToken) : base(apiToken, "/certificates")
        {
        }
        
        public async Task<Certificate> CreateCertificateAsync(CreateCertificateObject certificate)
        {
            var res = await SendPostRequest("/certificates", certificate);
            var createdCert = JsonSerializer.Deserialize<SingleCertificateRequestResult>(res, Settings.JsonSerializerOptions);

            return createdCert.Data;
        }
        
        public async Task<Certificate> UpdateCertificateAsync(long id, UpdateCertificateObject certificate)
        {
            var res = await SendPutRequest($"/certificates/{id}", certificate);
            var createdCert = JsonSerializer.Deserialize<SingleCertificateRequestResult>(res, Settings.JsonSerializerOptions);

            return createdCert.Data;
        }
    }
}