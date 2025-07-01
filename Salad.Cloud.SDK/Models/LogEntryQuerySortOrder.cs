using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The sort order of the log entries. `asc` will sort the log entries in chronological order. `desc` will sort the log entries in reverse chronological order.</summary>
public record LogEntryQuerySortOrder : ValueEnum<string>
{
    internal LogEntryQuerySortOrder(string value)
        : base(value) { }

    public LogEntryQuerySortOrder()
        : base("desc") { }

    public static LogEntryQuerySortOrder Desc = new("desc");
    public static LogEntryQuerySortOrder Asc = new("asc");
}
