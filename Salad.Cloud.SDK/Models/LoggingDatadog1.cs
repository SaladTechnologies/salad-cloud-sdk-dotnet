using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record LoggingDatadog1(
    [property: JsonPropertyName("host")] string Host,
    [property: JsonPropertyName("api_key")] string ApiKey,
    [property: JsonPropertyName("tags")] List<DatadogTags1>? Tags = null
);
