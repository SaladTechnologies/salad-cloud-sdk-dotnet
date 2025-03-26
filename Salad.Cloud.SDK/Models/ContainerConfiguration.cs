using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Configuration for creating a container within a container group. Defines the container image, resource requirements, environment variables, and other settings needed to deploy and run the container.</summary>
public record ContainerConfiguration(
    /// <value>The container image.</value>
    [property: JsonPropertyName("image")]
        string Image,
    /// <value>Specifies the resource requirements for a container.</value>
    [property: JsonPropertyName("resources")]
        ContainerResourceRequirements Resources,
    /// <value>Pass a command (and optional arguments) to override the ENTRYPOINT and CMD of a container image. Each element in the array represents a command segment or argument.</value>
    [property: JsonPropertyName("command")]
        List<string>? Command = null,
    /// <value>Key-value pairs of environment variables to set within the container. These variables will be available to processes running inside the container.</value>
    [property:
        JsonPropertyName("environment_variables"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? EnvironmentVariables = null,
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
        ContainerConfigurationLogging? Logging = null,
    /// <value>Specifies the priority level for container group execution, which determines resource allocation and scheduling precedence.</value>
    [property: JsonPropertyName("priority")]
        ContainerGroupPriority? Priority = null,
    /// <value>Authentication configuration for various container registry types, including AWS ECR, Docker Hub, GCP GAR, GCP GCR, and basic authentication.</value>
    [property:
        JsonPropertyName("registry_authentication"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerRegistryAuthentication? RegistryAuthentication = null
);
