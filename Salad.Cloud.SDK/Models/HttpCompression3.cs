using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record HttpCompression3 : ValueEnum<string>
{
    internal HttpCompression3(string value)
        : base(value) { }

    public HttpCompression3()
        : base("none") { }

    public static HttpCompression3 None = new("none");
    public static HttpCompression3 Gzip = new("gzip");
}
