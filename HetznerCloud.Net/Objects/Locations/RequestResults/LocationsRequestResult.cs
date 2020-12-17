using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Locations.Models;

namespace HetznerCloud.Net.Objects.Locations.RequestResults
{
    public class LocationsRequestResult : MultipleObjectsResultBase<Location>
    {
        [JsonPropertyName("locations")]
        public override List<Location> Data { get; set; }
    }
}