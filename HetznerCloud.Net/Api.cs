﻿using HetznerCloud.Net.Endpoints;

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
        
        /// <summary>
        /// Certificates endpoint
        /// </summary>
        public Certificates Certificates => new Certificates(ApiToken);
        
        /// <summary>
        /// Datacenters endpoint
        /// </summary>
        public Datacenters Datacenters => new Datacenters(ApiToken);
        
        /// <summary>
        /// Floating Ips endpoint
        /// </summary>
        public FloatingIps FloatingIps => new FloatingIps(ApiToken);
        
        /// <summary>
        /// Images endpoint
        /// </summary>
        public Images Images => new Images(ApiToken);
        
        /// <summary>
        /// Isos endpoint
        /// </summary>
        public Isos Isos => new Isos(ApiToken);

        /// <summary>
        /// Load balancers endpoint
        /// </summary>
        public LoadBalancers LoadBalancers => new LoadBalancers(ApiToken);

        /// <summary>
        /// Load balancer types endpoint
        /// </summary>
        public LoadBalancerTypes LoadBalancerTypes => new LoadBalancerTypes(ApiToken);

        /// <summary>
        /// Locations endpoint
        /// </summary>
        public Locations Locations => new Locations(ApiToken);

        /// <summary>
        /// Networks endpoint
        /// </summary>
        public Networks Networks => new Networks(ApiToken);

        /// <summary>
        /// Servers endpoint
        /// </summary>
        public Servers Servers => new Servers(ApiToken);

        /// <summary>
        /// Server types endpoint
        /// </summary>
        public ServerTypes ServerTypes => new ServerTypes(ApiToken);

        /// <summary>
        /// Ssh keys endpoint
        /// </summary>
        public SshKeys SshKeys => new SshKeys(ApiToken);

        /// <summary>
        /// Volumes endpoint
        /// </summary>
        public Volumes Volumes => new Volumes(ApiToken);
    }
}