using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record RegistryAuthenticationGcpGcr1(
    [property: JsonPropertyName("service_key")] string ServiceKey
);
