using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record HttpCompression2 : ValueEnum<string>
{
    internal HttpCompression2(string value)
        : base(value) { }

    public HttpCompression2()
        : base("none") { }

    public static HttpCompression2 None = new("none");
    public static HttpCompression2 Gzip = new("gzip");
}
