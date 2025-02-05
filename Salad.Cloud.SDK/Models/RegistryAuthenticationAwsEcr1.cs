using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record RegistryAuthenticationAwsEcr1(
    [property: JsonPropertyName("access_key_id")] string AccessKeyId,
    [property: JsonPropertyName("secret_access_key")] string SecretAccessKey
);
