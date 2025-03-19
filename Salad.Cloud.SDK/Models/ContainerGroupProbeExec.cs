using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Defines the exec action for a probe in a container group. This is used to execute a command inside a container for health checks.</summary>
public record ContainerGroupProbeExec(
    /// <value>The command to execute inside the container. Exit status of 0 is considered successful, any other exit status is considered failure.</value>
    [property: JsonPropertyName("command")]
        List<string> Command
);
