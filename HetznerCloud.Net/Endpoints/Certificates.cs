using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.Certificates;
using HetznerCloud.Net.Objects.Certificates.Models;
using HetznerCloud.Net.Objects.Certificates.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Certificates : 
        IGetObject<Certificate>, 
        IGetAllObjects<Certificate>,
        ICreateObject<CreateCertificateObject, Certificate>,
        IUpdateObject<UpdateCertificateObject, Certificate>,
        IDeleteObject
    {
        private readonly EndpointService<SingleCertificateRequestResult, CertificatesRequestResult, Certificate>
            _endpointService;

        private const string EndpointPath = "/certificates";

        public Certificates(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleCertificateRequestResult, CertificatesRequestResult, Certificate>(apiToken,
                    EndpointPath);
        }

        public async Task<Certificate> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<Certificate>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }

        public async Task<Certificate> CreateAsync(CreateCertificateObject objectToCreate)
        {
            return await _endpointService.CreateAsync<CreateCertificateObject>(objectToCreate);
        }

        public async Task<Certificate> UpdateAsync(long id, UpdateCertificateObject objectToUpdate)
        {
            return await _endpointService.UpdateAsync<UpdateCertificateObject>(id, objectToUpdate);
        }

        public void Delete(long id)
        {
            _endpointService.Delete(id);
        }
    }
}