using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.Volumes.Models;
using HetznerCloud.Net.Objects.Volumes.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Volumes : IGetObject<Volume>, IGetAllObjects<Volume>, IDeleteObject
    {
        private const string EndpointPath = "/volumes";
        
        private readonly EndpointService<SingleVolumeRequestResult, VolumesRequestResult, Volume>
            _endpointService;
        
        public Volumes(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleVolumeRequestResult, VolumesRequestResult, Volume>(apiToken, EndpointPath);
        }

        public async Task<Volume> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<Volume>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }

        public void Delete(long id)
        {
            _endpointService.Delete(id);
        }
    }
}