using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Common;
using HetznerCloud.Net.Objects.Datacenters.Models;
using HetznerCloud.Net.Objects.Images.Models;
using HetznerCloud.Net.Objects.Isos.Models;
using HetznerCloud.Net.Objects.LoadBalancers.Models;

namespace HetznerCloud.Net.Objects.Servers.Models
{
    public class Server
    {
        /// <summary>
        /// ID of Server
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; } 

        /// <summary>
        /// Name of the Server (must be unique per Project and a valid hostname as per RFC 1123)
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } 

        /// <summary>
        /// Status of the Server
        /// </summary>
        [JsonPropertyName("status")]
        public ServerStatuses Status { get; set; } 

        /// <summary>
        /// Point in time when the Server was created (in ISO-8601 format)
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime Created { get; set; } 

        /// <summary>
        /// Public network information.
        /// </summary>
        [JsonPropertyName("public_net")]
        public ServerPublicNetwork PublicNetwork { get; set; } 

        /// <summary>
        /// Private networks information
        /// </summary>
        [JsonPropertyName("private_net")]
        public List<ServerPrivateNetwork> PrivateNetwork { get; set; } 

        /// <summary>
        /// Type of Server - determines how much ram, disk and cpu a Server has
        /// </summary>
        [JsonPropertyName("server_type")]
        public ServerType ServerType { get; set; } 

        /// <summary>
        /// Datacenter this Server is located at
        /// </summary>
        [JsonPropertyName("datacenter")]
        public Datacenter Datacenter { get; set; } 

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("image")]
        public Image Image { get; set; } 

        /// <summary>
        /// ISO Image that is attached to this Server. Null if no ISO is attached.
        /// </summary>
        [JsonPropertyName("iso")]
        public Iso Iso { get; set; } 

        /// <summary>
        /// True if rescue mode is enabled. Server will then boot into rescue system on next reboot
        /// </summary>
        [JsonPropertyName("rescue_enabled")]
        public bool RescueEnabled { get; set; } 

        /// <summary>
        /// True if Server has been locked and is not available to user
        /// </summary>
        [JsonPropertyName("locked")]
        public bool Locked { get; set; } 

        /// <summary>
        /// Time window (UTC) in which the backup will run, or null if the backups are not enabled
        /// </summary>
        [JsonPropertyName("backup_window")]
        public string BackupWindow { get; set; } 

        /// <summary>
        /// Outbound Traffic for the current billing period in bytes
        /// </summary>
        [JsonPropertyName("outgoing_traffic")]
        public long OutgoingTraffic { get; set; } 

        /// <summary>
        /// Inbound Traffic for the current billing period in bytes
        /// </summary>
        [JsonPropertyName("ingoing_traffic")]
        public long IngoingTraffic { get; set; } 

        /// <summary>
        /// Free Traffic for the current billing period in bytes
        /// </summary>
        [JsonPropertyName("included_traffic")]
        public long IncludedTraffic { get; set; } 

        /// <summary>
        /// Protection configuration for the Server
        /// </summary>
        [JsonPropertyName("protection")]
        public ServerProtection Protection { get; set; } 

        /// <summary>
        /// User-defined labels (key-value pairs)
        /// </summary>
        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; } 

        /// <summary>
        /// IDs of Volumes assigned to this Server
        /// </summary>
        [JsonPropertyName("volumes")]
        public List<long> Volumes { get; set; } 

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("load_balancers")]
        public List<long> LoadBalancers { get; set; } 

        /// <summary>
        /// Size of the primary Disk
        /// </summary>
        [JsonPropertyName("primary_disk_size")]
        public long PrimaryDiskSize { get; set; }
    }
}