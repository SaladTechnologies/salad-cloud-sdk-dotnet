using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record InferenceEndpointJobEventAction : ValueEnum<string>
{
    internal InferenceEndpointJobEventAction(string value)
        : base(value) { }

    public InferenceEndpointJobEventAction()
        : base("created") { }

    public static InferenceEndpointJobEventAction Created = new("created");
    public static InferenceEndpointJobEventAction Started = new("started");
    public static InferenceEndpointJobEventAction Succeeded = new("succeeded");
    public static InferenceEndpointJobEventAction Cancelled = new("cancelled");
    public static InferenceEndpointJobEventAction Failed = new("failed");
}
