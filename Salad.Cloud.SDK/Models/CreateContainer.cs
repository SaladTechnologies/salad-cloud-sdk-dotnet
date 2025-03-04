using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a container</summary>
public record CreateContainer(
    [property: JsonPropertyName("image")] string Image,
    /// <value>Represents a container resource requirements</value>
    [property: JsonPropertyName("resources")]
        ContainerResourceRequirements Resources,
    /// <value>Pass a command (and optional arguments) to override the ENTRYPOINT and CMD of a container image.</value>
    [property: JsonPropertyName("command")]
        List<string>? Command = null,
    [property: JsonPropertyName("priority")] ContainerGroupPriority? Priority = null,
    [property:
        JsonPropertyName("environment_variables"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? EnvironmentVariables = null,
    [property: JsonPropertyName("logging")] CreateContainerLogging? Logging = null,
    [property: JsonPropertyName("registry_authentication")]
        CreateContainerRegistryAuthentication? RegistryAuthentication = null,
    [property:
        JsonPropertyName("image_caching"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? ImageCaching = null
);
