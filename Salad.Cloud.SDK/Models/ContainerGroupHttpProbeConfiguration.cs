using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Defines HTTP probe configuration for container health checks within a container group.</summary>
public record ContainerGroupHttpProbeConfiguration(
    /// <value>A collection of HTTP header name-value pairs used for configuring requests and responses in container group endpoints. Each header consists of a name and its corresponding value.</value>
    [property: JsonPropertyName("headers")]
        List<ContainerGroupProbeHttpHeader> Headers,
    /// <value>The HTTP path that will be probed to check container health.</value>
    [property: JsonPropertyName("path")]
        string Path,
    /// <value>The TCP port number to which the HTTP request will be sent.</value>
    [property: JsonPropertyName("port")]
        long Port,
    /// <value>The protocol scheme used for HTTP probe requests in container health checks.</value>
    [property: JsonPropertyName("scheme")]
        HttpScheme? Scheme
);
