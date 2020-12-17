using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Objects.Locations.Models;
using HetznerCloud.Net.Objects.Locations.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Locations : BaseEndpoint<SingleLocationRequestResult, LocationsRequestResult, Location>
    {
        private const string _endpointPath = "/locations";
        
        public Locations(string apiToken) : base(apiToken, _endpointPath)
        {
        }
    }
}