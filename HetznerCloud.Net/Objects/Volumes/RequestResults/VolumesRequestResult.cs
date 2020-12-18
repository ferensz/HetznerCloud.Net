using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Volumes.Models;

namespace HetznerCloud.Net.Objects.Volumes.RequestResults
{
    public class VolumesRequestResult : MultipleObjectsResultBase<Volume>
    {
        [JsonPropertyName("volumes")]
        public override List<Volume> Data { get; set; }
    }
}