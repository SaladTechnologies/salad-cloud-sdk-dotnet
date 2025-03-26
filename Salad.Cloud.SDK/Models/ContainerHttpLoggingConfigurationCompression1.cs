using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The compression algorithm to apply to logs before transmission</summary>
public record ContainerHttpLoggingConfigurationCompression1 : ValueEnum<string>
{
    internal ContainerHttpLoggingConfigurationCompression1(string value)
        : base(value) { }

    public ContainerHttpLoggingConfigurationCompression1()
        : base("none") { }

    public static ContainerHttpLoggingConfigurationCompression1 None = new("none");
    public static ContainerHttpLoggingConfigurationCompression1 Gzip = new("gzip");
}
