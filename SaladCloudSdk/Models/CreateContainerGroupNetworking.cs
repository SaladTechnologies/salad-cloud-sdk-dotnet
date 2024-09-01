using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents container group networking parameters</summary>
public record CreateContainerGroupNetworking(
    [property: JsonPropertyName("protocol")] ContainerNetworkingProtocol Protocol,
    [property: JsonPropertyName("port")] long Port,
    [property: JsonPropertyName("auth")] bool Auth
);
