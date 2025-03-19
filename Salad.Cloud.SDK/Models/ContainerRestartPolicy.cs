using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Specifies the policy for restarting containers when they exit or fail.</summary>
public record ContainerRestartPolicy : ValueEnum<string>
{
    internal ContainerRestartPolicy(string value)
        : base(value) { }

    public ContainerRestartPolicy()
        : base("always") { }

    public static ContainerRestartPolicy Always = new("always");
    public static ContainerRestartPolicy OnFailure = new("on_failure");
    public static ContainerRestartPolicy Never = new("never");
}
