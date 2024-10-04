using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents container group networking parameters</summary>
public record ContainerGroupNetworking(
    [property: JsonPropertyName("protocol")] ContainerNetworkingProtocol Protocol,
    [property: JsonPropertyName("port")] long Port,
    [property: JsonPropertyName("auth")] bool Auth,
    [property: JsonPropertyName("dns")] string Dns,
    [property:
        JsonPropertyName("load_balancer"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerGroupNetworking.ContainerGroupNetworkingLoadBalancer? LoadBalancer = null,
    [property:
        JsonPropertyName("single_connection_limit"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? SingleConnectionLimit = null,
    [property:
        JsonPropertyName("client_request_timeout"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ClientRequestTimeout = null,
    [property:
        JsonPropertyName("server_response_timeout"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ServerResponseTimeout = null
)
{
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
}
