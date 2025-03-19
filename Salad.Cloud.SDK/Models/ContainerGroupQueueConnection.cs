using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Configuration for connecting a container group to a message queue system, enabling asynchronous communication between services.</summary>
public record ContainerGroupQueueConnection(
    /// <value>The endpoint path for accessing the queue service, relative to the base URL of the queue server.</value>
    [property: JsonPropertyName("path")]
        string Path,
    /// <value>The network port number used to connect to the queue service. Must be a valid TCP/IP port between 1 and 65535.</value>
    [property: JsonPropertyName("port")]
        long Port,
    /// <value>Unique identifier for the queue. Must start with a lowercase letter, can contain lowercase letters, numbers, and hyphens, and must end with a letter or number.</value>
    [property: JsonPropertyName("queue_name")]
        string QueueName
);
