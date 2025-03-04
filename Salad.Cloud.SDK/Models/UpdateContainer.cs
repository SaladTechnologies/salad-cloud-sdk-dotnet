using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents an update container object</summary>
public record UpdateContainer(
    [property: JsonPropertyName("image")] string? Image = null,
    [property: JsonPropertyName("resources")] Resources? Resources1 = null,
    /// <value>Pass a command (and optional arguments) to override the ENTRYPOINT and CMD of a container image.</value>
    [property: JsonPropertyName("command")]
        List<string>? Command = null,
    [property: JsonPropertyName("priority")] ContainerGroupPriority? Priority = null,
    [property:
        JsonPropertyName("environment_variables"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? EnvironmentVariables = null,
    [property: JsonPropertyName("logging")] UpdateContainerLogging? Logging = null,
    [property: JsonPropertyName("registry_authentication")]
        UpdateContainerRegistryAuthentication? RegistryAuthentication = null,
    [property:
        JsonPropertyName("image_caching"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? ImageCaching = null
);
