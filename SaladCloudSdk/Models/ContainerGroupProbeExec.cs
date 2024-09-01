using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

public record ContainerGroupProbeExec([property: JsonPropertyName("command")] List<string> Command);
