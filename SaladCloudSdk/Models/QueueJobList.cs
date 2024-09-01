using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a list of queue jobs</summary>
public record QueueJobList([property: JsonPropertyName("items")] List<QueueJob> Items);
