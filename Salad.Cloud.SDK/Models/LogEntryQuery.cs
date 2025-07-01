using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a query for logs</summary>
public record LogEntryQuery(
    /// <value>The end time of the time range</value>
    [property: JsonPropertyName("end_time")]
        string EndTime,
    /// <value>The query string for filtering logs</value>
    [property: JsonPropertyName("query")]
        string Query,
    /// <value>The start time of the time range</value>
    [property: JsonPropertyName("start_time")]
        string StartTime,
    /// <value>The maximum number of items per page.</value>
    [property:
        JsonPropertyName("page_size"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? PageSize = null,
    /// <value>The sort order of the log entries. `asc` will sort the log entries in chronological order. `desc` will sort the log entries in reverse chronological order.</value>
    [property:
        JsonPropertyName("sort_order"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        LogEntryQuerySortOrder? SortOrder = null
);
