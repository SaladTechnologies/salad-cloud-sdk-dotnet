using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a list of container groups</summary>
public record ContainerGroupList([property: JsonPropertyName("items")] List<ContainerGroup> Items);
