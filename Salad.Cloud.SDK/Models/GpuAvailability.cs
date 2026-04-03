using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record GpuAvailability(
    /// <value>The number of available GPU batches</value>
    [property:
        JsonPropertyName("available_gpu_batch"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? AvailableGpuBatch = null,
    /// <value>The number of available high-end GPUs</value>
    [property:
        JsonPropertyName("available_gpu_high"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? AvailableGpuHigh = null,
    /// <value>The number of available low-end GPUs</value>
    [property:
        JsonPropertyName("available_gpu_low"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? AvailableGpuLow = null,
    /// <value>The number of available medium-end GPUs</value>
    [property:
        JsonPropertyName("available_gpu_medium"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? AvailableGpuMedium = null,
    /// <value>The number of on-call GPUs available</value>
    [property:
        JsonPropertyName("on_call_gpu"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? OnCallGpu = null
);
