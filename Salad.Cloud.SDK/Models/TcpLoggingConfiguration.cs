using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Configuration for forwarding container logs to a remote TCP endpoint</summary>
public record TcpLoggingConfiguration(
    /// <value>The hostname or IP address of the remote TCP logging endpoint</value>
    [property: JsonPropertyName("host")]
        string Host,
    /// <value>The port number on which the TCP logging endpoint is listening</value>
    [property: JsonPropertyName("port")]
        long Port
);
