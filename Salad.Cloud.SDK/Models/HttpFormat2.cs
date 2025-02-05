using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record HttpFormat2 : ValueEnum<string>
{
    internal HttpFormat2(string value)
        : base(value) { }

    public HttpFormat2()
        : base("json") { }

    public static HttpFormat2 Json = new("json");
    public static HttpFormat2 JsonLines = new("json_lines");
}
