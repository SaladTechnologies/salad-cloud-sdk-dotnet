using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a list of container group instances</summary>
public record ContainerGroupInstances(
    [property: JsonPropertyName("instances")] List<ContainerGroupInstance> Instances
);
