using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.SshKeys.Models;
using HetznerCloud.Net.Objects.SshKeys.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class SshKeys : IGetObject<SshKey>, IGetAllObjects<SshKey>, IDeleteObject
    {
        private const string EndpointPath = "/ssh_keys";
        
        private readonly EndpointService<SingleSshKeyRequestResult, SshKeysRequestResult, SshKey>
            _endpointService;
        
        public SshKeys(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleSshKeyRequestResult, SshKeysRequestResult, SshKey>(apiToken, EndpointPath);
        }
        
        public async Task<SshKey> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<SshKey>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }

        public void Delete(long id)
        {
            _endpointService.Delete(id);
        }
    }
}