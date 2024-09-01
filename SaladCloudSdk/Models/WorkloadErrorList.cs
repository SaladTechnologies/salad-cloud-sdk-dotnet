using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a list of workload errors</summary>
public record WorkloadErrorList([property: JsonPropertyName("items")] List<WorkloadError> Items);
