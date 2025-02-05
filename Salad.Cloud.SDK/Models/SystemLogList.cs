using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a list of system logs</summary>
public record SystemLogList([property: JsonPropertyName("items")] List<SystemLog> Items);
