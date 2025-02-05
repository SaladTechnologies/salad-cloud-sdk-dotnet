using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record HttpCompression1 : ValueEnum<string>
{
    internal HttpCompression1(string value)
        : base(value) { }

    public HttpCompression1()
        : base("none") { }

    public static HttpCompression1 None = new("none");
    public static HttpCompression1 Gzip = new("gzip");
}
