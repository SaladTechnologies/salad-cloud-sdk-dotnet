using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Configuration for sending container logs to an HTTP endpoint. Defines how logs are formatted, compressed, and transmitted.</summary>
public record ContainerLoggingConfigurationHttp2(
    /// <value>The hostname or IP address of the HTTP logging endpoint</value>
    [property: JsonPropertyName("host")]
        string Host,
    /// <value>The port number of the HTTP logging endpoint (1-65535)</value>
    [property: JsonPropertyName("port")]
        long Port,
    /// <value>The format in which logs will be delivered</value>
    [property: JsonPropertyName("format")]
        ContainerLoggingHttpFormat Format,
    [property: JsonPropertyName("compression")] object Compression,
    /// <value>Optional username for HTTP authentication</value>
    [property: JsonPropertyName("user")]
        string? User = null,
    /// <value>Optional password for HTTP authentication</value>
    [property: JsonPropertyName("password")]
        string? Password = null,
    /// <value>Optional URL path for the HTTP endpoint</value>
    [property: JsonPropertyName("path")]
        string? Path = null,
    /// <value>Optional HTTP headers to include in log transmission requests</value>
    [property:
        JsonPropertyName("headers"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ContainerLoggingHttpHeader>? Headers = null
);
