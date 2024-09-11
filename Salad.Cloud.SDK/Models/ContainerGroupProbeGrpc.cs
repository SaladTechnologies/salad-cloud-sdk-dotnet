using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record ContainerGroupProbeGrpc(
    [property: JsonPropertyName("service")] string Service,
    [property: JsonPropertyName("port")] long Port
);
