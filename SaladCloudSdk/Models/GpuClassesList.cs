using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a list of GPU classes</summary>
public record GpuClassesList(
    /// <value>The list of GPU classes</value>
    [property: JsonPropertyName("items")]
        List<GpuClass> Items
);
