using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The format in which logs will be delivered</summary>
public record ContainerLoggingHttpFormat : ValueEnum<string>
{
    internal ContainerLoggingHttpFormat(string value)
        : base(value) { }

    public ContainerLoggingHttpFormat()
        : base("json") { }

    public static ContainerLoggingHttpFormat Json = new("json");
    public static ContainerLoggingHttpFormat JsonLines = new("json_lines");
}
