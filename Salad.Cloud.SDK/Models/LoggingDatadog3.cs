using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record LoggingDatadog3(
    [property: JsonPropertyName("host")] string Host,
    [property: JsonPropertyName("api_key")] string ApiKey,
    [property: JsonPropertyName("tags")] List<DatadogTags3>? Tags = null
);
