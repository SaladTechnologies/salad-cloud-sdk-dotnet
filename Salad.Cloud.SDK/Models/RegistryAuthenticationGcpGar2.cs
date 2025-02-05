using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record RegistryAuthenticationGcpGar2(
    [property: JsonPropertyName("service_key")] string ServiceKey
);
