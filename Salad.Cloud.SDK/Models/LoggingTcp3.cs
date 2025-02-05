using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record LoggingTcp3(
    [property: JsonPropertyName("host")] string Host,
    [property: JsonPropertyName("port")] long Port
);
