using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents update container group networking parameters</summary>
public record UpdateContainerGroupNetworking(
    /// <value>The port number to expose on the container group</value>
    [property: JsonPropertyName("port")]
        long? Port = null
);
