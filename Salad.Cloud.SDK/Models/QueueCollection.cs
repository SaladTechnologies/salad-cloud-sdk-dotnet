using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a Queue Collection</summary>
public record QueueCollection(
    /// <value>The list of queues.</value>
    [property: JsonPropertyName("items")]
        List<Queue> Items
);
