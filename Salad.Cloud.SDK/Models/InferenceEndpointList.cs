using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a page from the collection of inference endpoints.</summary>
public record InferenceEndpointList(
    /// <value>The list of inference endpoints.</value>
    [property: JsonPropertyName("items")]
        List<InferenceEndpoint> Items,
    /// <value>The page number.</value>
    [property: JsonPropertyName("page")]
        long Page,
    /// <value>The maximum number of items per page.</value>
    [property: JsonPropertyName("page_size")]
        long PageSize,
    /// <value>The total number of items in the collection.</value>
    [property: JsonPropertyName("total_size")]
        long TotalSize
);
