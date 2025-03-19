using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The protocol scheme used for HTTP probe requests in container health checks.</summary>
public record HttpScheme : ValueEnum<string>
{
    internal HttpScheme(string value)
        : base(value) { }

    public HttpScheme()
        : base("http") { }

    public static HttpScheme Http = new("http");
    public static HttpScheme Https = new("https");
}
