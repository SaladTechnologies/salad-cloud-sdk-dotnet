using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record ContainerGroupStatus : ValueEnum<string>
{
    internal ContainerGroupStatus(string value)
        : base(value) { }

    public ContainerGroupStatus()
        : base("pending") { }

    public static ContainerGroupStatus Pending = new("pending");
    public static ContainerGroupStatus Running = new("running");
    public static ContainerGroupStatus Stopped = new("stopped");
    public static ContainerGroupStatus Succeeded = new("succeeded");
    public static ContainerGroupStatus Failed = new("failed");
    public static ContainerGroupStatus Deploying = new("deploying");
}
