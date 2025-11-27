using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record CpuAvailability(
    /// <value>The number of available CPU cores</value>
    [property:
        JsonPropertyName("available_cpu_batch"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? AvailableCpuBatch = null,
    /// <value>The amount of on-call CPU</value>
    [property:
        JsonPropertyName("on_call_cpu"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? OnCallCpu = null
);
