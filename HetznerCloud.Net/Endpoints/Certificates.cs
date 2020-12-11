using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Objects.Certificates;

namespace HetznerCloud.Net.Endpoints
{
    public class Certificates : BaseEndpoint
    {
        public Certificates(string apiToken) : base(apiToken)
        {
        }

        public async Task<Certificate> GetCertificateAsync(long id)
        {
            var res = await SendRequest($"/certificates/{id}");
            var certificate = JsonSerializer.Deserialize<SingleCertificateRequestResult>(res, Settings.JsonSerializerOptions);

            return certificate.Certificate;
        }

        public async Task<List<Certificate>> GetAllCertificatesAsync()
        {
            List<Certificate> resultCertificates = new List<Certificate>();
             
            var res = await SendRequest("/certificates");
            var certificatesPage = JsonSerializer.Deserialize<CertificatesRequestResult>(res, Settings.JsonSerializerOptions);

            if (certificatesPage != null)
            {
                var lastPage = certificatesPage.Meta.Pagination.LastPage;
                
                resultCertificates.AddRange(certificatesPage.Certificates);

                while (certificatesPage.Meta.Pagination.Page < lastPage)
                {
                    res = await SendRequest("/certificates");
                    certificatesPage = JsonSerializer.Deserialize<CertificatesRequestResult>(res, Settings.JsonSerializerOptions);
                    
                    resultCertificates.AddRange(certificatesPage.Certificates);
                }
            }

            return resultCertificates;
        }

        public async Task<Certificate> CreateCertificateAsync(CreateCertificateObject certificate)
        {
            var res = await SendPostRequest("/certificates", certificate);
            var createdCert = JsonSerializer.Deserialize<SingleCertificateRequestResult>(res, Settings.JsonSerializerOptions);

            return createdCert.Certificate;
        }
        
        public async Task<Certificate> UpdateCertificateAsync(long id, UpdateCertificateObject certificate)
        {
            var res = await SendPutRequest($"/certificates/{id}", certificate);
            var createdCert = JsonSerializer.Deserialize<SingleCertificateRequestResult>(res, Settings.JsonSerializerOptions);

            return createdCert.Certificate;
        }

        public async void DeleteCertificateAsync(long id)
        {
            var res = await SendDeleteRequest($"/certificates/{id}", null);
        }
    }
}