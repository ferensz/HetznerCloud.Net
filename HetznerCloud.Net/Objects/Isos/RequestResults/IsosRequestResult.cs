using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Isos.Models;

namespace HetznerCloud.Net.Objects.Isos.RequestResults
{
    public class IsosRequestResult : MultipleObjectsResultBase<Iso>
    {
        [JsonPropertyName("isos")]
        public override List<Iso> Data { get; set; }
    }
}