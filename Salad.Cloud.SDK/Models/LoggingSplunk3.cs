using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record LoggingSplunk3(
    [property: JsonPropertyName("host")] string Host,
    [property: JsonPropertyName("token")] string Token
);
