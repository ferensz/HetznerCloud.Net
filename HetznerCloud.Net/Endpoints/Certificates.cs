using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects;
using HetznerCloud.Net.Objects.Certificates;
using HetznerCloud.Net.Objects.Certificates.Models;
using HetznerCloud.Net.Objects.Certificates.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Certificates : 
        BaseEndpoint<SingleCertificateRequestResult, CertificatesRequestResult, Certificate>, 
        ICreateObject<CreateCertificateObject, SingleCertificateRequestResult, Certificate>, 
        IUpdateObject<UpdateCertificateObject, SingleCertificateRequestResult, Certificate>,
        IDeleteObject
    {
        private BaseEndpointCreate<SingleCertificateRequestResult, CertificatesRequestResult, Certificate, CreateCertificateObject>
            _baseCreateEndpoint;
        
        private BaseEndpointUpdate<SingleCertificateRequestResult, CertificatesRequestResult, Certificate, UpdateCertificateObject>
            _baseUpdateEndpoint;
        
        private BaseEndpointDelete<SingleCertificateRequestResult, CertificatesRequestResult, Certificate>
            _baseUpdateDelete;
        
        private const string _endpointPath = "/certificates";
        
        public Certificates(string apiToken) : base(apiToken, _endpointPath)
        {
            _baseCreateEndpoint = new BaseEndpointCreate<SingleCertificateRequestResult, CertificatesRequestResult, Certificate, CreateCertificateObject>(apiToken, _endpointPath);
            _baseUpdateEndpoint = new BaseEndpointUpdate<SingleCertificateRequestResult, CertificatesRequestResult, Certificate, UpdateCertificateObject>(apiToken, _endpointPath);
            _baseUpdateDelete = new BaseEndpointDelete<SingleCertificateRequestResult, CertificatesRequestResult, Certificate>(apiToken, _endpointPath);
        }
        
        public async Task<Certificate> CreateAsync(CreateCertificateObject objectToCreate)
        {
            return await _baseCreateEndpoint.CreateAsync(objectToCreate);
        }

        public async Task<Certificate> UpdateAsync(long id, UpdateCertificateObject objectToUpdate)
        {
            return await _baseUpdateEndpoint.UpdateAsync(id, objectToUpdate);
        }

        public void Delete(long id)
        {
            _baseUpdateDelete.Delete(id);
        }
    }
}