using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a list of queue jobs</summary>
public record QueueJobList([property: JsonPropertyName("items")] List<QueueJob> Items);
