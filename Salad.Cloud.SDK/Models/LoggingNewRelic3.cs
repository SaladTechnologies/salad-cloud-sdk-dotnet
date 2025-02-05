using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record LoggingNewRelic3(
    [property: JsonPropertyName("host")] string Host,
    [property: JsonPropertyName("ingestion_key")] string IngestionKey
);
