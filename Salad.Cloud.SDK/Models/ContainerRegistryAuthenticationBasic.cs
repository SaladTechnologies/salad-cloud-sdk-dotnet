using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Basic username and password authentication for generic container registries</summary>
public record ContainerRegistryAuthenticationBasic(
    /// <value>Password for registry authentication</value>
    [property: JsonPropertyName("password")]
        string Password,
    /// <value>Username for registry authentication</value>
    [property: JsonPropertyName("username")]
        string Username
);
