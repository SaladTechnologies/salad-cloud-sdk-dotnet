using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The format in which logs will be delivered</summary>
public record Format : ValueEnum<string>
{
    internal Format(string value)
        : base(value) { }

    public Format()
        : base("json") { }

    public static Format Json = new("json");
    public static Format JsonLines = new("json_lines");
}
