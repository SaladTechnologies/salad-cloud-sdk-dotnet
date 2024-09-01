using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

public record ContainerGroupProbeHttpHeaders2(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("value")] string Value
);
