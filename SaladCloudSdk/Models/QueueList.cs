using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a list of queues</summary>
public record QueueList([property: JsonPropertyName("items")] List<Queue> Items);
