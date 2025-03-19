using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a Queue Job Collection</summary>
public record QueueJobCollection(
    /// <value>The list of queue jobs</value>
    [property: JsonPropertyName("items")]
        List<QueueJob> Items
);
