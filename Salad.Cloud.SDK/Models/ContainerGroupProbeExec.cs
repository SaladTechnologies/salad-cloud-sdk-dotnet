using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record ContainerGroupProbeExec([property: JsonPropertyName("command")] List<string> Command);
