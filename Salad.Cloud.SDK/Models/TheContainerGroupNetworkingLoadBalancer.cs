using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The container group networking load balancer.</summary>
public record TheContainerGroupNetworkingLoadBalancer : ValueEnum<string>
{
    internal TheContainerGroupNetworkingLoadBalancer(string value)
        : base(value) { }

    public TheContainerGroupNetworkingLoadBalancer()
        : base("round_robin") { }

    public static TheContainerGroupNetworkingLoadBalancer RoundRobin = new("round_robin");
    public static TheContainerGroupNetworkingLoadBalancer LeastNumberOfConnections =
        new("least_number_of_connections");
}
