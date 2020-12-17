using System.Runtime.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public enum LoadBalancerServiceTargetTypes
    {
        Server,
        [EnumMember(Value = "label_selector")]
        LabelSelector,
        Ip
    }
}