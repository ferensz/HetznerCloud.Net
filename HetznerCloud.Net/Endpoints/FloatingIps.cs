using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects;
using HetznerCloud.Net.Objects.Datacenters;
using HetznerCloud.Net.Objects.FloatingIps;
using HetznerCloud.Net.Objects.FloatingIps.Models;
using HetznerCloud.Net.Objects.FloatingIps.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class FloatingIps : 
        IGetObject<FloatingIp>,
        IGetAllObjects<FloatingIp>,
        ICreateObject<CreateFloatingIpObject, FloatingIp>, 
        IUpdateObject<UpdateFloatingIpObject, FloatingIp>,
        IDeleteObject
    {
        private const string EndpointPath = "/floating_ips";
        
        private readonly EndpointService<SingleFloatingIpRequestResult, FloatingIpsRequestResult, FloatingIp>
            _endpointService;
        
        public FloatingIps(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleFloatingIpRequestResult, FloatingIpsRequestResult, FloatingIp>(apiToken,
                    EndpointPath);
        }
        
        public async Task<FloatingIp> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<FloatingIp>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }

        public async Task<FloatingIp> CreateAsync(CreateFloatingIpObject objectToCreate)
        {
            return await _endpointService.CreateAsync<CreateFloatingIpObject>(objectToCreate);
        }

        public async Task<FloatingIp> UpdateAsync(long id, UpdateFloatingIpObject objectToUpdate)
        {
            return await _endpointService.UpdateAsync<UpdateFloatingIpObject>(id, objectToUpdate);
        }

        public void Delete(long id)
        {
            _endpointService.Delete(id);
        }
    }
}