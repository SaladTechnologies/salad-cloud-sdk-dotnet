using System.Text.Json.Serialization;
using SaladCloudSdk.Json;

namespace SaladCloudSdk.Models;

public record ContainerNetworkingProtocol : ValueEnum<string>
{
    internal ContainerNetworkingProtocol(string value)
        : base(value) { }

    public ContainerNetworkingProtocol()
        : base("http") { }

    public static ContainerNetworkingProtocol Http = new("http");
}
