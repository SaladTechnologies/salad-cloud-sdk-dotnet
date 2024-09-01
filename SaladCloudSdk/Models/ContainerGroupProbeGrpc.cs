using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

public record ContainerGroupProbeGrpc(
    [property: JsonPropertyName("service")] string Service,
    [property: JsonPropertyName("port")] long Port
);
