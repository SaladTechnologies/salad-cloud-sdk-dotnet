using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents the price of a GPU class for a given container group priority</summary>
public record GpuClassPrice(
    [property: JsonPropertyName("priority")] ContainerGroupPriority Priority,
    /// <value>The price</value>
    [property: JsonPropertyName("price")]
        string Price
);
