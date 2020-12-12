using System.Collections.Generic;
using System.Text.Json.Serialization;
using HetznerCloud.Net.Core.Requests;

namespace HetznerCloud.Net.Objects
{
    public class MultipleObjectsResultBase<T>
    {
        public virtual List<T> Data { get; set; }
        
        public Meta Meta { get; set; }
    }
}