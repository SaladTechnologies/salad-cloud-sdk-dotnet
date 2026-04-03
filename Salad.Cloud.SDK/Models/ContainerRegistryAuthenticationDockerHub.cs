using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Authentication details for Docker Hub registry</summary>
public record ContainerRegistryAuthenticationDockerHub(
    /// <value>Docker Hub personal access token (PAT)</value>
    [property: JsonPropertyName("personal_access_token")]
        string PersonalAccessToken,
    /// <value>Docker Hub username</value>
    [property: JsonPropertyName("username")]
        string Username
);
