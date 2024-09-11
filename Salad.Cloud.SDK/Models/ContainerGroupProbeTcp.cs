using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record ContainerGroupProbeTcp([property: JsonPropertyName("port")] long Port);
