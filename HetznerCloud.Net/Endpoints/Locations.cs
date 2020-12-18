using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Endpoints.Interfaces;
using HetznerCloud.Net.Objects.Locations.Models;
using HetznerCloud.Net.Objects.Locations.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Locations : IGetObject<Location>, IGetAllObjects<Location>
    {
        private const string EndpointPath = "/locations";
        
        private readonly EndpointService<SingleLocationRequestResult, LocationsRequestResult, Location>
            _endpointService;
        
        public Locations(string apiToken)
        {
            _endpointService =
                new EndpointService<SingleLocationRequestResult, LocationsRequestResult, Location>(apiToken,
                    EndpointPath);
        }

        public async Task<Location> GetAsync(long id)
        {
            return await _endpointService.GetAsync(id);
        }

        public async Task<List<Location>> GetAllAsync()
        {
            return await _endpointService.GetAllAsync();
        }
    }
}