using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.Datacenters;
using HetznerCloud.Net.Objects.FloatingIps;
using HetznerCloud.Net.Objects.FloatingIps.Models;
using HetznerCloud.Net.Objects.FloatingIps.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class FloatingIps : 
        BaseEndpoint<SingleFloatingIpRequestResult, FloatingIpsRequestResult, FloatingIp>,
        ICreateObject<CreateFloatingIpObject, SingleFloatingIpRequestResult, FloatingIp>, 
        IUpdateObject<UpdateFloatingIpObject, SingleFloatingIpRequestResult, FloatingIp>,
        IDeleteObject
    {
        private BaseEndpointCreate<SingleFloatingIpRequestResult, FloatingIpsRequestResult, FloatingIp, CreateFloatingIpObject>
            _baseCreateEndpoint;
        
        private BaseEndpointUpdate<SingleFloatingIpRequestResult, FloatingIpsRequestResult, FloatingIp, UpdateFloatingIpObject>
            _baseUpdateEndpoint;
        
        private BaseEndpointDelete<SingleFloatingIpRequestResult, FloatingIpsRequestResult, FloatingIp>
            _baseUpdateDelete;
        
        private const string _endpointPath = "/floating_ips";
        
        public FloatingIps(string apiToken) : base(apiToken, _endpointPath)
        {
            _baseCreateEndpoint = new BaseEndpointCreate<SingleFloatingIpRequestResult, FloatingIpsRequestResult, FloatingIp, CreateFloatingIpObject>(apiToken, _endpointPath);
            _baseUpdateEndpoint = new BaseEndpointUpdate<SingleFloatingIpRequestResult, FloatingIpsRequestResult, FloatingIp, UpdateFloatingIpObject>(apiToken, _endpointPath);
            _baseUpdateDelete = new BaseEndpointDelete<SingleFloatingIpRequestResult, FloatingIpsRequestResult, FloatingIp>(apiToken, _endpointPath);
        }

        public async Task<FloatingIp> CreateAsync(CreateFloatingIpObject objectToCreate)
        {
            return await _baseCreateEndpoint.CreateAsync(objectToCreate);
        }

        public async Task<FloatingIp> UpdateAsync(long id, UpdateFloatingIpObject objectToUpdate)
        {
            return await _baseUpdateEndpoint.UpdateAsync(id, objectToUpdate);
        }

        public void Delete(long id)
        {
            _baseUpdateDelete.Delete(id);
        }
    }
}