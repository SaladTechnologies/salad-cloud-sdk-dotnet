using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a container</summary>
public record Container(
    [property: JsonPropertyName("image")] string Image,
    /// <value>Represents a container resource requirements</value>
    [property: JsonPropertyName("resources")]
        ContainerResourceRequirements Resources,
    [property: JsonPropertyName("command")] List<string> Command,
    [property: JsonPropertyName("priority")] ContainerGroupPriority? Priority = null,
    [property:
        JsonPropertyName("size"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Size = null,
    [property:
        JsonPropertyName("hash"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Hash = null,
    [property:
        JsonPropertyName("environment_variables"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? EnvironmentVariables = null,
    [property: JsonPropertyName("logging")] ContainerLogging? Logging = null,
    [property:
        JsonPropertyName("image_caching"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? ImageCaching = null
);
