using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record RegistryAuthenticationBasic1(
    [property: JsonPropertyName("username")] string Username,
    [property: JsonPropertyName("password")] string Password
);
