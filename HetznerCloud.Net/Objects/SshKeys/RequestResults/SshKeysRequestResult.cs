using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.SshKeys.Models;

namespace HetznerCloud.Net.Objects.SshKeys.RequestResults
{
    public class SshKeysRequestResult : MultipleObjectsResultBase<SshKey>
    {
        [JsonPropertyName("ssh_keys")]
        public override List<SshKey> Data { get; set; }
    }
}