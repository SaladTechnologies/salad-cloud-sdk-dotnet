using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record LoggingDatadog2(
    [property: JsonPropertyName("host")] string Host,
    [property: JsonPropertyName("api_key")] string ApiKey,
    [property: JsonPropertyName("tags")] List<DatadogTags2>? Tags = null
);
