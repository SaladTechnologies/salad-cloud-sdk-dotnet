using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record LoggingAxiom3(
    [property: JsonPropertyName("host")] string Host,
    [property: JsonPropertyName("api_token")] string ApiToken,
    [property: JsonPropertyName("dataset")] string Dataset
);
