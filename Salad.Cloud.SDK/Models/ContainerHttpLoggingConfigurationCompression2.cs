using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The compression algorithm to apply to logs before transmission</summary>
public record ContainerHttpLoggingConfigurationCompression2 : ValueEnum<string>
{
    internal ContainerHttpLoggingConfigurationCompression2(string value)
        : base(value) { }

    public ContainerHttpLoggingConfigurationCompression2()
        : base("none") { }

    public static ContainerHttpLoggingConfigurationCompression2 None = new("none");
    public static ContainerHttpLoggingConfigurationCompression2 Gzip = new("gzip");
}
