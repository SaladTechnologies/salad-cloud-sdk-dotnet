using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record RegistryAuthenticationDockerHub1(
    [property: JsonPropertyName("username")] string Username,
    [property: JsonPropertyName("personal_access_token")] string PersonalAccessToken
);
