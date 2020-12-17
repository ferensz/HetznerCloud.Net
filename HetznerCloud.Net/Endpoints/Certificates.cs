﻿using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
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
    public class Certificates : IGetObject<Certificate>, IGetAllObjects<Certificate>, IDeleteObject
    {
        private BaseEndpointGetSingle<SingleCertificateRequestResult, Certificate> _baseGetSingleEndpoint;

        private BaseEndpointGetMultiple<CertificatesRequestResult, Certificate> _baseGetAllEndpoint;
        
        private BaseEndpointCreate<SingleCertificateRequestResult, CreateCertificateObject, Certificate>
            _baseCreateEndpoint;
        
        private BaseEndpointUpdate<SingleCertificateRequestResult, UpdateCertificateObject, Certificate>
            _baseUpdateEndpoint;
        
        private BaseEndpointDelete
            _baseUpdateDelete;
        
        private const string _endpointPath = "/certificates";
        
        public Certificates(string apiToken)
        {
            _baseGetSingleEndpoint =
                new BaseEndpointGetSingle<SingleCertificateRequestResult, Certificate>(apiToken, _endpointPath);
            _baseGetAllEndpoint =
                new BaseEndpointGetMultiple<CertificatesRequestResult, Certificate>(apiToken, _endpointPath);
            _baseCreateEndpoint = new BaseEndpointCreate<SingleCertificateRequestResult, CreateCertificateObject, Certificate>(apiToken, _endpointPath);
            _baseUpdateEndpoint = new BaseEndpointUpdate<SingleCertificateRequestResult, UpdateCertificateObject, Certificate>(apiToken, _endpointPath);
            _baseUpdateDelete = new BaseEndpointDelete(apiToken, _endpointPath);
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