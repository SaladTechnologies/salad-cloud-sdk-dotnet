using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>A paginated collection of container groups that provides a structured way to access multiple container group resources in a single response.</summary>
public record ContainerGroupCollection(
    /// <value>An array containing container group objects. Each object represents a discrete container group with its own properties, configuration, and status.</value>
    [property: JsonPropertyName("items")]
        List<ContainerGroup> Items
);
