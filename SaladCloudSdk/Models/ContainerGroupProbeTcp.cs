using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

public record ContainerGroupProbeTcp([property: JsonPropertyName("port")] long Port);
