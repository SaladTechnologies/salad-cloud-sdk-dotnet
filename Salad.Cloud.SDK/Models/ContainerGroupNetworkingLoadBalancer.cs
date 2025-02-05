using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record ContainerGroupNetworkingLoadBalancer : ValueEnum<string>
{
    internal ContainerGroupNetworkingLoadBalancer(string value)
        : base(value) { }

    public ContainerGroupNetworkingLoadBalancer()
        : base("round_robin") { }

    public static ContainerGroupNetworkingLoadBalancer RoundRobin = new("round_robin");
    public static ContainerGroupNetworkingLoadBalancer LeastNumberOfConnections =
        new("least_number_of_connections");
}
