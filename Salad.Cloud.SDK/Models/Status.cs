using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The current status.</summary>
public record Status : ValueEnum<string>
{
    internal Status(string value)
        : base(value) { }

    public Status()
        : base("pending") { }

    public static Status Pending = new("pending");
    public static Status Running = new("running");
    public static Status Succeeded = new("succeeded");
    public static Status Cancelled = new("cancelled");
    public static Status Failed = new("failed");
}
