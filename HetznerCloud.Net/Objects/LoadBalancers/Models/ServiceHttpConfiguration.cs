using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class ServiceHttpConfiguration
    {
        /// <summary>
        /// Name of the cookie used for sticky sessions
        /// </summary>
        [JsonPropertyName("cookie_name")] public string CookieName { get; set; }

        /// <summary>
        /// Lifetime of the cookie used for sticky sessions
        /// </summary>
        [JsonPropertyName("cookie_lifetime")] public int CookieLifetime { get; set; }

        /// <summary>
        /// IDs of the Certificates to use for TLS/SSL termination by the Load Balancer; empty for TLS/SSL passthrough or if protocol is "http"
        /// </summary>
        [JsonPropertyName("certificates")] public List<long> Certificates { get; set; }

        /// <summary>
        /// Redirect HTTP requests to HTTPS. Only available if protocol is "https". Default false
        /// </summary>
        [JsonPropertyName("redirect_http")] public bool RedirectHttp { get; set; }

        /// <summary>
        /// Use sticky sessions. Only available if protocol is "http" or "https". Default false
        /// </summary>
        [JsonPropertyName("sticky_sessions")] public bool StickySessions { get; set; }
    }
}