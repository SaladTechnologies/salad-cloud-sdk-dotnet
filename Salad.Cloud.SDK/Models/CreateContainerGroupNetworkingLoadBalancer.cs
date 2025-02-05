using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record CreateContainerGroupNetworkingLoadBalancer : ValueEnum<string>
{
    internal CreateContainerGroupNetworkingLoadBalancer(string value)
        : base(value) { }

    public CreateContainerGroupNetworkingLoadBalancer()
        : base("round_robin") { }

    public static CreateContainerGroupNetworkingLoadBalancer RoundRobin = new("round_robin");
    public static CreateContainerGroupNetworkingLoadBalancer LeastNumberOfConnections =
        new("least_number_of_connections");
}
