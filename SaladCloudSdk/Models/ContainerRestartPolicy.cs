using System.Text.Json.Serialization;
using SaladCloudSdk.Json;

namespace SaladCloudSdk.Models;

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
