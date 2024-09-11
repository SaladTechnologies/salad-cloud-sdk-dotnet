using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents update container group networking parameters</summary>
public record UpdateContainerGroupNetworking(
    [property: JsonPropertyName("port")] long? Port = null
);
