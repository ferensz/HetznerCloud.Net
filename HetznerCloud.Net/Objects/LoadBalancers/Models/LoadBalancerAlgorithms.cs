using System.Runtime.Serialization;

namespace HetznerCloud.Net.Objects.LoadBalancers.Models
{
    public enum LoadBalancerAlgorithms
    {
        [EnumMember(Value = "round_robin")]
        RoundRobin,
        [EnumMember(Value = "least_connections")]
        LeastConnections
    }
}