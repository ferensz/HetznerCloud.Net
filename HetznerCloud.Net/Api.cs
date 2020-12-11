using HetznerCloud.Net.Endpoints;

namespace HetznerCloud.Net
{
    /// <summary>
    /// Main entry point to access Hetzner Cloud API
    /// </summary>
    public class CloudApi
    {
        /// <summary>
        /// API token to access Hetzner Cloud API
        /// </summary>
        public string ApiToken { get; set; }

        /// <summary>
        /// Actions endpoint
        /// </summary>
        public Actions Actions => new Actions(ApiToken);
        
        public Certificates Certificates => new Certificates(ApiToken);
        
        public Datacenters Datacenters => new Datacenters(ApiToken);
    }
}