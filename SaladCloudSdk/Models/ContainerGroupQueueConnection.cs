using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents container group queue connection</summary>
public record ContainerGroupQueueConnection(
    [property: JsonPropertyName("path")] string Path,
    [property: JsonPropertyName("port")] long Port,
    [property: JsonPropertyName("queue_name")] string QueueName
);
