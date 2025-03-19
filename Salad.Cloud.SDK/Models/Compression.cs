using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The compression algorithm to apply to logs before transmission</summary>
public record Compression : ValueEnum<string>
{
    internal Compression(string value)
        : base(value) { }

    public Compression()
        : base("none") { }

    public static Compression None = new("none");
    public static Compression Gzip = new("gzip");
}
