using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record HttpFormat3 : ValueEnum<string>
{
    internal HttpFormat3(string value)
        : base(value) { }

    public HttpFormat3()
        : base("json") { }

    public static HttpFormat3 Json = new("json");
    public static HttpFormat3 JsonLines = new("json_lines");
}
