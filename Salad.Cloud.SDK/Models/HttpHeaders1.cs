using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record HttpHeaders1(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("value")] string Value
);
