using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a list of queues</summary>
public record QueueList(
    /// <value>The list of queues.</value>
    [property: JsonPropertyName("items")]
        List<Queue> Items
);
