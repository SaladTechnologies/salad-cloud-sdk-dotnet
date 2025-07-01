using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

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
        bool? IsHighDemand = null,
    /// <value>The type of GPU class</value>
    [property:
        JsonPropertyName("gpu_class_type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        GpuClassType? GpuClassType1 = null,
    /// <value>The minimum vCPU count</value>
    [property:
        JsonPropertyName("min_vcpu"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MinVcpu = null,
    /// <value>The maximum vCPU count</value>
    [property:
        JsonPropertyName("max_vcpu"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxVcpu = null,
    /// <value>The minimum RAM amount in GB</value>
    [property:
        JsonPropertyName("min_ram"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MinRam = null,
    /// <value>The maximum RAM amount in GB</value>
    [property:
        JsonPropertyName("max_ram"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxRam = null,
    /// <value>The minimum storage amount in GB</value>
    [property:
        JsonPropertyName("min_storage"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MinStorage = null,
    /// <value>The maximum storage amount in GB</value>
    [property:
        JsonPropertyName("max_storage"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxStorage = null
);
