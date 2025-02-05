using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record LoggingAxiom1(
    [property: JsonPropertyName("host")] string Host,
    [property: JsonPropertyName("api_token")] string ApiToken,
    [property: JsonPropertyName("dataset")] string Dataset
);
