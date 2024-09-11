using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents an event for queue job</summary>
public record QueueJobEvent(
    [property: JsonPropertyName("action")] QueueJobEvent.QueueJobEventAction Action,
    [property: JsonPropertyName("time")] string Time
)
{
    public record QueueJobEventAction : ValueEnum<string>
    {
        internal QueueJobEventAction(string value)
            : base(value) { }

        public QueueJobEventAction()
            : base("created") { }

        public static QueueJobEventAction Created = new("created");
        public static QueueJobEventAction Started = new("started");
        public static QueueJobEventAction Succeeded = new("succeeded");
        public static QueueJobEventAction Cancelled = new("cancelled");
        public static QueueJobEventAction Failed = new("failed");
    }
}
