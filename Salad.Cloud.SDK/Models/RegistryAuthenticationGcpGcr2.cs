using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record RegistryAuthenticationGcpGcr2(
    [property: JsonPropertyName("service_key")] string ServiceKey
);
