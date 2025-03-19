using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Configuration for sending container logs to New Relic's log management platform.</summary>
public record NewRelicLoggingConfiguration(
    /// <value>The New Relic endpoint host for log ingestion (e.g., log-api.newrelic.com).</value>
    [property: JsonPropertyName("host")]
        string Host,
    /// <value>The New Relic license or ingestion key used for authentication and data routing.</value>
    [property: JsonPropertyName("ingestion_key")]
        string IngestionKey
);
