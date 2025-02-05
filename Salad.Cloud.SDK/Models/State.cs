using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The state of the container group instance</summary>
public record State : ValueEnum<string>
{
    internal State(string value)
        : base(value) { }

    public State()
        : base("allocating") { }

    public static State Allocating = new("allocating");
    public static State Downloading = new("downloading");
    public static State Creating = new("creating");
    public static State Running = new("running");
    public static State Stopping = new("stopping");
}
