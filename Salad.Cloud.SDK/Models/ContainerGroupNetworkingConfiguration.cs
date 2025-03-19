using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Network configuration for container groups that defines connectivity, routing, and access control settings</summary>
public record ContainerGroupNetworkingConfiguration(
    /// <value>Whether authentication is required for network access to the container group</value>
    [property: JsonPropertyName("auth")]
        bool Auth,
    /// <value>Domain name or URL endpoint for the container group's network interface</value>
    [property: JsonPropertyName("dns")]
        string Dns,
    /// <value>The container group networking load balancer.</value>
    [property: JsonPropertyName("load_balancer")]
        TheContainerGroupNetworkingLoadBalancer LoadBalancer,
    /// <value>The container group networking port.</value>
    [property: JsonPropertyName("port")]
        long Port,
    /// <value>Defines the communication protocol used for network traffic between containers or external systems. Currently supports HTTP protocol for web-based communication.</value>
    [property: JsonPropertyName("protocol")]
        ContainerNetworkingProtocol Protocol,
    /// <value>The container group networking client request timeout.</value>
    [property:
        JsonPropertyName("client_request_timeout"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ClientRequestTimeout = null,
    /// <value>The container group networking server response timeout.</value>
    [property:
        JsonPropertyName("server_response_timeout"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ServerResponseTimeout = null,
    /// <value>The container group networking single connection limit flag.</value>
    [property:
        JsonPropertyName("single_connection_limit"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? SingleConnectionLimit = null
);
