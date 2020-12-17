using System.Collections.Generic;
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
        private readonly BaseEndpointGetSingle<SingleCertificateRequestResult, Certificate> _baseGetSingleEndpoint;
        private readonly BaseEndpointGetMultiple<CertificatesRequestResult, Certificate> _baseGetAllEndpoint;

        private readonly BaseEndpointCreate<SingleCertificateRequestResult, CreateCertificateObject, Certificate>
            _baseCreateEndpoint;

        private readonly BaseEndpointUpdate<SingleCertificateRequestResult, UpdateCertificateObject, Certificate>
            _baseUpdateEndpoint;

        private readonly BaseEndpointDelete
            _baseUpdateDelete;

        private const string EndpointPath = "/certificates";

        public Certificates(string apiToken)
        {
            _baseGetSingleEndpoint =
                new BaseEndpointGetSingle<SingleCertificateRequestResult, Certificate>(apiToken, EndpointPath);
            _baseGetAllEndpoint =
                new BaseEndpointGetMultiple<CertificatesRequestResult, Certificate>(apiToken, EndpointPath);
            _baseCreateEndpoint =
                new BaseEndpointCreate<SingleCertificateRequestResult, CreateCertificateObject, Certificate>(apiToken,
                    EndpointPath);
            _baseUpdateEndpoint =
                new BaseEndpointUpdate<SingleCertificateRequestResult, UpdateCertificateObject, Certificate>(apiToken,
                    EndpointPath);
            _baseUpdateDelete = new BaseEndpointDelete(apiToken, EndpointPath);
        }

        public async Task<Certificate> GetAsync(long id)
        {
            return await _baseGetSingleEndpoint.GetAsync(id);
        }

        public async Task<List<Certificate>> GetAllAsync()
        {
            return await _baseGetAllEndpoint.GetAllAsync();
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