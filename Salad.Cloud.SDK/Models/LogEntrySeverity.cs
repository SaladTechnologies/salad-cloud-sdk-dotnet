using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The severity level of the log entry</summary>
public record LogEntrySeverity : ValueEnum<string>
{
    internal LogEntrySeverity(string value)
        : base(value) { }

    public LogEntrySeverity()
        : base("default") { }

    public static LogEntrySeverity Default_ = new("default");
    public static LogEntrySeverity Debug = new("debug");
    public static LogEntrySeverity Info = new("info");
    public static LogEntrySeverity Notice = new("notice");
    public static LogEntrySeverity Warning = new("warning");
    public static LogEntrySeverity Error = new("error");
    public static LogEntrySeverity Critical = new("critical");
    public static LogEntrySeverity Alert = new("alert");
    public static LogEntrySeverity Emergency = new("emergency");
}
