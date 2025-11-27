using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Network configuration for container groups that defines connectivity, routing, and access control settings</summary>
public class ContainerGroupNetworkingConfiguration
{
    /// <value>Whether authentication is required for network access to the container group</value>
    [JsonPropertyName("auth")]
    public bool Auth { get; init; }

    /// <value>Domain name or URL endpoint for the container group's network interface</value>
    [JsonPropertyName("dns")]
    public string Dns { get; init; }

    /// <value>The container group networking load balancer.</value>
    [JsonPropertyName("load_balancer")]
    public TheContainerGroupNetworkingLoadBalancer LoadBalancer { get; init; }

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
    public ContainerGroupNetworkingConfiguration(
        bool auth,
        string dns,
        TheContainerGroupNetworkingLoadBalancer load_balancer,
        long port,
        ContainerNetworkingProtocol protocol,
        long? client_request_timeout = null,
        long? server_response_timeout = null,
        bool? single_connection_limit = null
    ) { }

    public override string ToString()
    {
        return $"{nameof(ContainerGroupNetworkingConfiguration)} {{Auth = {Auth}, Dns = {Dns}, LoadBalancer = {LoadBalancer}, Port = {Port}, Protocol = {Protocol}, ClientRequestTimeout = {ClientRequestTimeout}, ServerResponseTimeout = {ServerResponseTimeout}, SingleConnectionLimit = {SingleConnectionLimit}}}";
    }
}
