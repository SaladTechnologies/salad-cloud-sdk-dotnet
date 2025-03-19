using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The job status</summary>
public record QueueJobStatus : ValueEnum<string>
{
    internal QueueJobStatus(string value)
        : base(value) { }

    public QueueJobStatus()
        : base("pending") { }

    public static QueueJobStatus Pending = new("pending");
    public static QueueJobStatus Running = new("running");
    public static QueueJobStatus Succeeded = new("succeeded");
    public static QueueJobStatus Cancelled = new("cancelled");
    public static QueueJobStatus Failed = new("failed");
}
