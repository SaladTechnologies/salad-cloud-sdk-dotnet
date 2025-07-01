using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record LogEntry(
    /// <value>The time when the log entry was received</value>
    [property: JsonPropertyName("receive_time")]
        string ReceiveTime,
    /// <value>The resource associated with the log entry</value>
    [property: JsonPropertyName("resource")]
        LogEntryResource Resource,
    /// <value>The severity level of the log entry</value>
    [property: JsonPropertyName("severity")]
        LogEntrySeverity Severity_,
    /// <value>The timestamp of the log entry</value>
    [property: JsonPropertyName("time")]
        string Time,
    /// <value>The log message in JSON format.</value>
    [property:
        JsonPropertyName("json_log"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? JsonLog = null,
    /// <value>The parent span ID of the log entry</value>
    [property:
        JsonPropertyName("parent_span_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? ParentSpanId = null,
    /// <value>The span ID of the log entry</value>
    [property:
        JsonPropertyName("span_Id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? SpanId = null,
    /// <value>The log message in text format.</value>
    [property:
        JsonPropertyName("text_log"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? TextLog = null,
    /// <value>The trace ID of the log entry</value>
    [property:
        JsonPropertyName("trace_Id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? TraceId = null
);
