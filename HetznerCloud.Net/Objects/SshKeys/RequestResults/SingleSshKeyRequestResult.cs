using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.SshKeys.Models;

namespace HetznerCloud.Net.Objects.SshKeys.RequestResults
{
    public class SingleSshKeyRequestResult : SingleObjectResultBase<SshKey>
    {
        [JsonPropertyName("ssh_key")]
        public override SshKey Data { get; set; }
    }
}