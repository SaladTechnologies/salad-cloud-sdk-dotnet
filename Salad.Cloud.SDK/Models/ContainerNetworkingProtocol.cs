using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Defines the communication protocol used for network traffic between containers or external systems. Currently supports HTTP protocol for web-based communication.</summary>
public record ContainerNetworkingProtocol : ValueEnum<string>
{
    internal ContainerNetworkingProtocol(string value)
        : base(value) { }

    public ContainerNetworkingProtocol()
        : base("http") { }

    public static ContainerNetworkingProtocol Http = new("http");
}
