using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a GPU Class</summary>
public record GpuClass(
    /// <value>The unique identifier</value>
    [property: JsonPropertyName("id")]
        string Id,
    /// <value>The GPU class name</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>The list of prices for each container group priority</value>
    [property: JsonPropertyName("prices")]
        List<GpuClassPrice> Prices,
    /// <value>Whether the GPU class is in high demand</value>
    [property:
        JsonPropertyName("is_high_demand"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? IsHighDemand = null
);
