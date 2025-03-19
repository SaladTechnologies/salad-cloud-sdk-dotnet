using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Configuration for a TCP probe used to check container health via network connectivity.</summary>
public record ContainerGroupTcpProbe(
    /// <value>The TCP port number that the probe should connect to. Must be a valid port number between 0 and 65535.</value>
    [property: JsonPropertyName("port")]
        long Port
);
