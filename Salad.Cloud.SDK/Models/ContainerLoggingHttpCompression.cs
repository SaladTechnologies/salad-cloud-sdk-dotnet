using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The compression algorithm to apply to logs before transmission</summary>
public record ContainerLoggingHttpCompression : ValueEnum<string>
{
    internal ContainerLoggingHttpCompression(string value)
        : base(value) { }

    public ContainerLoggingHttpCompression()
        : base("none") { }

    public static ContainerLoggingHttpCompression None = new("none");
    public static ContainerLoggingHttpCompression Gzip = new("gzip");
}
