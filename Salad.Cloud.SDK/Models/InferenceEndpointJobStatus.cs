using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The current status.</summary>
public record InferenceEndpointJobStatus : ValueEnum<string>
{
    internal InferenceEndpointJobStatus(string value)
        : base(value) { }

    public InferenceEndpointJobStatus()
        : base("pending") { }

    public static InferenceEndpointJobStatus Pending = new("pending");
    public static InferenceEndpointJobStatus Running = new("running");
    public static InferenceEndpointJobStatus Succeeded = new("succeeded");
    public static InferenceEndpointJobStatus Cancelled = new("cancelled");
    public static InferenceEndpointJobStatus Failed = new("failed");
}
