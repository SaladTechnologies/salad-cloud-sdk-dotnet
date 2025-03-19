using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a request to update a container group instance</summary>
public record ContainerGroupInstancePatch(
    /// <value>The cost of deleting the container group instance</value>
    [property: JsonPropertyName("deletion_cost")]
        long? DeletionCost = null
);
