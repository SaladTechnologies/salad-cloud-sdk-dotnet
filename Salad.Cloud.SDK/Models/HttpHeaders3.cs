using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record HttpHeaders3(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("value")] string Value
);
