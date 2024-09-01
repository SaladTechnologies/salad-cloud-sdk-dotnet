using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a container group instance status count</summary>
public record ContainerGroupInstanceStatusCount(
    [property: JsonPropertyName("allocating_count")] long AllocatingCount,
    [property: JsonPropertyName("creating_count")] long CreatingCount,
    [property: JsonPropertyName("running_count")] long RunningCount,
    [property: JsonPropertyName("stopping_count")] long StoppingCount
);
