using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects;
using HetznerCloud.Net.Objects.Images;
using HetznerCloud.Net.Objects.Images.Models;
using HetznerCloud.Net.Objects.Images.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Images : BaseEndpoint<SingleImageRequestResult, ImagesRequestResult, Image>,
        IUpdateObject<UpdateImageObject, SingleImageRequestResult, Image>
    {
        private BaseEndpointUpdate<SingleImageRequestResult, ImagesRequestResult, Image, UpdateImageObject>
            _baseUpdateEndpoint;

        private const string _endpointPath = "/images";
        
        public Images(string apiToken) : base(apiToken, _endpointPath)
        {
            _baseUpdateEndpoint = new BaseEndpointUpdate<SingleImageRequestResult, ImagesRequestResult, Image, UpdateImageObject>(apiToken, _endpointPath); 
        }

        public async Task<Image> UpdateAsync(long id, UpdateImageObject objectToUpdate)
        {
            return await _baseUpdateEndpoint.UpdateAsync(id, objectToUpdate);
        }
    }
}