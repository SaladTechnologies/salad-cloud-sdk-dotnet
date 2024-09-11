using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record ContainerGroupProbeHttpHeaders2(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("value")] string Value
);
