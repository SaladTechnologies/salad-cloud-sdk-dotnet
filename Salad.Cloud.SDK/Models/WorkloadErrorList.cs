using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a list of workload errors</summary>
public record WorkloadErrorList(
    /// <value>A list of workload errors</value>
    [property: JsonPropertyName("items")]
        List<WorkloadError> Items
);
