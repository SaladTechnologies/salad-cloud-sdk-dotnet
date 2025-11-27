using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents the price of a GPU class for a given container group priority</summary>
public record GpuClassPrice(
    /// <value>Specifies the priority level for container group execution, which determines resource allocation and scheduling precedence.</value>
    [property: JsonPropertyName("priority")]
        ContainerGroupPriority? Priority,
    /// <value>The price</value>
    [property: JsonPropertyName("price")]
        string Price
);
