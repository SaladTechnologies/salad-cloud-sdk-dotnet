using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a list of container groups</summary>
public record ContainerGroupList([property: JsonPropertyName("items")] List<ContainerGroup> Items);
