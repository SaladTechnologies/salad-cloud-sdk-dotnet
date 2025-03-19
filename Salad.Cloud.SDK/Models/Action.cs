using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The action that was taken on the queue job</summary>
public record Action : ValueEnum<string>
{
    internal Action(string value)
        : base(value) { }

    public Action()
        : base("created") { }

    public static Action Created = new("created");
    public static Action Started = new("started");
    public static Action Succeeded = new("succeeded");
    public static Action Cancelled = new("cancelled");
    public static Action Failed = new("failed");
}
