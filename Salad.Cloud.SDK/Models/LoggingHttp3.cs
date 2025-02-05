using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record LoggingHttp3(
    [property: JsonPropertyName("host")] string Host,
    [property: JsonPropertyName("port")] long Port,
    [property: JsonPropertyName("format")] HttpFormat3 Format,
    [property: JsonPropertyName("compression")] HttpCompression3 Compression,
    [property: JsonPropertyName("user")] string? User = null,
    [property: JsonPropertyName("password")] string? Password = null,
    [property: JsonPropertyName("path")] string? Path = null,
    [property: JsonPropertyName("headers")] List<HttpHeaders4>? Headers = null
);
