using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record ContainerNetworkingProtocol : ValueEnum<string>
{
    internal ContainerNetworkingProtocol(string value)
        : base(value) { }

    public ContainerNetworkingProtocol()
        : base("http") { }

    public static ContainerNetworkingProtocol Http = new("http");
}
