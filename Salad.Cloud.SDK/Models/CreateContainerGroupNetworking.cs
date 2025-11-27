using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Network configuration for container groups specifying connectivity parameters, including authentication, protocol, and timeout settings</summary>
public class CreateContainerGroupNetworking
{
    /// <value>Determines whether authentication is required for network connections to the container group</value>
    [JsonPropertyName("auth")]
    public bool Auth { get; init; }

    /// <value>The container group networking port.</value>
    [JsonPropertyName("port")]
    public long Port { get; init; }

    /// <value>Defines the communication protocol used for network traffic between containers or external systems. Currently supports HTTP protocol for web-based communication.</value>
    [JsonPropertyName("protocol")]
    public ContainerNetworkingProtocol Protocol { get; init; }

    /// <value>The container group networking client request timeout.</value>
    [
        JsonPropertyName("client_request_timeout"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
    public long? ClientRequestTimeout { get; init; }

    /// <value>The container group networking load balancer.</value>
    [
        JsonPropertyName("load_balancer"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
    public TheContainerGroupNetworkingLoadBalancer? LoadBalancer { get; init; }

    /// <value>The container group networking server response timeout.</value>
    [
        JsonPropertyName("server_response_timeout"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
    public long? ServerResponseTimeout { get; init; }

    /// <value>The container group networking single connection limit flag.</value>
    [
        JsonPropertyName("single_connection_limit"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
    public bool? SingleConnectionLimit { get; init; }

    // Constructor with defaults applied
    public CreateContainerGroupNetworking(
        bool auth,
        long port,
        ContainerNetworkingProtocol protocol,
        long? client_request_timeout = null,
        TheContainerGroupNetworkingLoadBalancer? load_balancer = null,
        long? server_response_timeout = null,
        bool? single_connection_limit = null
    ) { }

    public override string ToString()
    {
        return $"{nameof(CreateContainerGroupNetworking)} {{Auth = {Auth}, Port = {Port}, Protocol = {Protocol}, ClientRequestTimeout = {ClientRequestTimeout}, LoadBalancer = {LoadBalancer}, ServerResponseTimeout = {ServerResponseTimeout}, SingleConnectionLimit = {SingleConnectionLimit}}}";
    }
}
