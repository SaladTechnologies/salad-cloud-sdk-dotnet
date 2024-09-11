using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record ContainerProbeHttpScheme : ValueEnum<string>
{
    internal ContainerProbeHttpScheme(string value)
        : base(value) { }

    public ContainerProbeHttpScheme()
        : base("http") { }

    public static ContainerProbeHttpScheme Http = new("http");
}
