using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Objects.Images.Models;

namespace HetznerCloud.Net.Objects.Images.RequestResults
{
    public class ImagesRequestResult : MultipleObjectsResultBase<Image>
    {
        [JsonPropertyName("images")] 
        public override List<Image> Data { get; set; }
    }
}