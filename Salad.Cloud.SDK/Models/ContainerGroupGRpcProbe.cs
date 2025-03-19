using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Configuration for gRPC-based health probes in container groups, used to determine container health status.</summary>
public record ContainerGroupGRpcProbe(
    /// <value>The port number on which the gRPC health check service is exposed.</value>
    [property: JsonPropertyName("port")]
        long Port,
    /// <value>The name of the gRPC service that implements the health check protocol.</value>
    [property: JsonPropertyName("service")]
        string Service
);
