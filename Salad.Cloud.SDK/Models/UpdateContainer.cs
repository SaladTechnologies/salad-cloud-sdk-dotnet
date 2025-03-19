using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents an update container object</summary>
public record UpdateContainer(
    /// <value>Pass a command (and optional arguments) to override the ENTRYPOINT and CMD of a container image.</value>
    [property: JsonPropertyName("command")]
        List<string>? Command = null,
    /// <value>Environment variables to set in the container.</value>
    [property:
        JsonPropertyName("environment_variables"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? EnvironmentVariables = null,
    /// <value>The container image to use.</value>
    [property: JsonPropertyName("image")]
        string? Image = null,
    /// <value>The container image caching.</value>
    [property:
        JsonPropertyName("image_caching"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? ImageCaching = null,
    /// <value>Configuration options for directing container logs to a logging provider. This schema enables you to specify a single logging destination for container output, supporting monitoring, debugging, and analytics use cases. Each provider has its own configuration parameters defined in the referenced schemas. Only one logging provider can be selected at a time.</value>
    [property:
        JsonPropertyName("logging"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerLoggingConfiguration? Logging = null,
    /// <value>Specifies the priority level for container group execution, which determines resource allocation and scheduling precedence.</value>
    [property: JsonPropertyName("priority")]
        ContainerGroupPriority? Priority = null,
    /// <value>Authentication configuration for various container registry types, including AWS ECR, Docker Hub, GCP GAR, GCP GCR, and basic authentication.</value>
    [property:
        JsonPropertyName("registry_authentication"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerRegistryAuthentication? RegistryAuthentication = null,
    /// <value>Defines the resource specifications that can be modified for a container group, including CPU, memory, GPU classes, and storage allocations.</value>
    [property: JsonPropertyName("resources")]
        ContainerResourceUpdateSchema? Resources = null
);
