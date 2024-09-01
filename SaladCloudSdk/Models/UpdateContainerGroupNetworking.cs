using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents update container group networking parameters</summary>
public record UpdateContainerGroupNetworking(
    [property: JsonPropertyName("port")] long? Port = null
);
