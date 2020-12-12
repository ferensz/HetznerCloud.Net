using HetznerCloud.Net.Objects.Datacenters;
using HetznerCloud.Net.Objects.FloatingIps;

namespace HetznerCloud.Net.Endpoints
{
    public class FloatingIps : BaseEndpoint<SingleFloatingIpRequestResult, FloatingIpsRequestResult, FloatingIp>
    {
        public FloatingIps(string apiToken) : base(apiToken, "/floating_ips")
        {
        }
    }
}