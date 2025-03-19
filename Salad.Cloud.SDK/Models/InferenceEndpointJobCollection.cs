using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a collection of inference endpoint jobs</summary>
public record InferenceEndpointJobCollection(
    /// <value>The list of inference endpoint jobs.</value>
    [property: JsonPropertyName("items")]
        List<InferenceEndpointJob> Items,
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
