using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>A collection of container group instances returned as part of a paginated response or batch operation result.</summary>
public record ContainerGroupInstanceCollection(
    /// <value>An array of container group instances, each representing a deployed container group with its current state and configuration information.</value>
    [property: JsonPropertyName("instances")]
        List<ContainerGroupInstance> Instances
);
