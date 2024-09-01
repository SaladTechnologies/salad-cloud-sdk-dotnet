using System.Text.Json.Serialization;
using SaladCloudSdk.Json;

namespace SaladCloudSdk.Models;

public record ContainerProbeHttpScheme : ValueEnum<string>
{
    internal ContainerProbeHttpScheme(string value)
        : base(value) { }

    public ContainerProbeHttpScheme()
        : base("http") { }

    public static ContainerProbeHttpScheme Http = new("http");
}
