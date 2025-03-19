using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a container with its configuration and resource requirements.</summary>
public record Container(
    /// <value>List of commands to run inside the container. Each command is a string representing a command-line instruction.</value>
    [property: JsonPropertyName("command")]
        List<string> Command,
    /// <value>The container image.</value>
    [property: JsonPropertyName("image")]
        string Image,
    /// <value>Specifies the resource requirements for a container.</value>
    [property: JsonPropertyName("resources")]
        ContainerResourceRequirements Resources,
    /// <value>Environment variables to set in the container.</value>
    [property:
        JsonPropertyName("environment_variables"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? EnvironmentVariables = null,
    /// <value>SHA-256 hash (64-character hexadecimal string)</value>
    [property:
        JsonPropertyName("hash"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Hash = null,
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
    /// <value>Size of the container in bytes.</value>
    [property:
        JsonPropertyName("size"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Size = null
);
