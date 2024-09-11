using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a container resource requirements</summary>
public record ContainerResourceRequirements(
    [property: JsonPropertyName("cpu")] long Cpu,
    [property: JsonPropertyName("memory")] long Memory,
    [property: JsonPropertyName("gpu_classes")] List<string>? GpuClasses = null,
    [property: JsonPropertyName("storage_amount")] long? StorageAmount = null
);
