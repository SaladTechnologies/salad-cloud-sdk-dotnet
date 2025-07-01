using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The type of GPU class</summary>
public record GpuClassType : ValueEnum<string>
{
    internal GpuClassType(string value)
        : base(value) { }

    public GpuClassType()
        : base("community") { }

    public static GpuClassType Community = new("community");
    public static GpuClassType Secure = new("secure");
}
