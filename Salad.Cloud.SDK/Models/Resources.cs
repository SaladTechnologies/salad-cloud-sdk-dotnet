using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record Resources(
    [property: JsonPropertyName("cpu")] long? Cpu = null,
    [property: JsonPropertyName("memory")] long? Memory = null,
    [property: JsonPropertyName("gpu_classes")] List<string>? GpuClasses = null,
    [property: JsonPropertyName("storage_amount")] long? StorageAmount = null
);
