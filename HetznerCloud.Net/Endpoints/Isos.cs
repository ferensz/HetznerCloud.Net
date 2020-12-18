using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.Isos.Models;
using HetznerCloud.Net.Objects.Isos.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Isos : IGetObject<Iso>, IGetAllObjects<Iso>
    {
        private const string EndpointPath = "/isos";
        
        private readonly EndpointService<SingleIsoRequestResult, IsosRequestResult, Iso>
            _endpointService;
        
        public Isos(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleIsoRequestResult, IsosRequestResult, Iso>(apiToken, EndpointPath);
        }

        public async Task<Iso> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<Iso>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }
    }
}