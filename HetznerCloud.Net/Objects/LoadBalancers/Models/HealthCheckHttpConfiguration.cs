using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public class HealthCheckHttpConfiguration
    {
        /// <summary>
        /// Host header to send in the HTTP request. May not contain spaces, percent or backslash symbols. Can be null, in that case no host header is sent.
        /// </summary>
        [JsonPropertyName("domain")] public string Domain { get; set; }

        /// <summary>
        /// HTTP path to use for health checks
        /// </summary>
        [JsonPropertyName("path")] public string Path { get; set; }

        /// <summary>
        /// String that must be contained in HTTP response in order to pass the health check
        /// </summary>
        [JsonPropertyName("response")] public string Response { get; set; }

        /// <summary>
        /// List of returned HTTP status codes in order to pass the health check.
        /// Supports the wildcards ? for exactly one character and * for multiple ones.
        /// The default is to pass the health check for any status code between 2?? and 3??.
        /// </summary>
        [JsonPropertyName("status_codes")] public List<string> StatusCodes { get; set; }

        /// <summary>
        /// Use HTTPS for health check
        /// </summary>
        [JsonPropertyName("tls")] public bool Tls { get; set; }
    }
}