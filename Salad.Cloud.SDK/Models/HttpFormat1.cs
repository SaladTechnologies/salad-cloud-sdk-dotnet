using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record HttpFormat1 : ValueEnum<string>
{
    internal HttpFormat1(string value)
        : base(value) { }

    public HttpFormat1()
        : base("json") { }

    public static HttpFormat1 Json = new("json");
    public static HttpFormat1 JsonLines = new("json_lines");
}
