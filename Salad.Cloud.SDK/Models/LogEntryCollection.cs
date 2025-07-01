using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a page of organization logs</summary>
public record LogEntryCollection(
    /// <value>A collection of log entries</value>
    [property: JsonPropertyName("items")]
        List<LogEntry> Items,
    /// <value>The organization name.</value>
    [property: JsonPropertyName("organization_name")]
        string OrganizationName,
    /// <value>The maximum time page boundary. This may be used when getting paginated results.</value>
    [property: JsonPropertyName("page_max_time")]
        string PageMaxTime,
    /// <value>The minimum time page boundary. This may be used when getting paginated results.</value>
    [property: JsonPropertyName("page_min_time")]
        string PageMinTime
);
