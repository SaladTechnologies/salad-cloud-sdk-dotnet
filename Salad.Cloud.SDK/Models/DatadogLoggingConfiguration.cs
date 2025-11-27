using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Configuration for forwarding container logs to Datadog monitoring service.</summary>
public record DatadogLoggingConfiguration(
    /// <value>The Datadog intake server host URL where logs will be sent.</value>
    [property: JsonPropertyName("host")]
        string Host,
    /// <value>The Datadog API key used for authentication when sending logs.</value>
    [property: JsonPropertyName("api_key")]
        string ApiKey,
    /// <value>Optional metadata tags to attach to logs for filtering and categorization in Datadog.</value>
    [property: JsonPropertyName("tags")]
        List<DatadogTagForContainerLogging>? Tags
);
