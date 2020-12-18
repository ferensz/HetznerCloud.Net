using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects;
using HetznerCloud.Net.Objects.Images;
using HetznerCloud.Net.Objects.Images.Models;
using HetznerCloud.Net.Objects.Images.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Images : IGetObject<Image>, IGetAllObjects<Image>, IUpdateObject<UpdateImageObject, Image>
    {
        private const string EndpointPath = "/images";
        
        private readonly EndpointService<SingleImageRequestResult, ImagesRequestResult, Image>
            _endpointService;
        
        public Images(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleImageRequestResult, ImagesRequestResult, Image>(apiToken, EndpointPath);
        }
        
        public async Task<Image> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<Image>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }

        public async Task<Image> UpdateAsync(long id, UpdateImageObject objectToUpdate)
        {
            return await _endpointService.UpdateAsync<UpdateImageObject>(id, objectToUpdate);
        }
    }
}