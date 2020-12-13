using HetznerCloud.Net.Endpoints.Base;
using HetznerCloud.Net.Objects.Isos.Models;
using HetznerCloud.Net.Objects.Isos.RequestResults;

namespace HetznerCloud.Net.Endpoints
{
    public class Isos : BaseEndpoint<SingleIsoRequestResult, IsosRequestResult, Iso>
    {
        private const string _endpointPath = "/isos";
        
        public Isos(string apiToken) : base(apiToken, _endpointPath)
        {
        }
    }
}