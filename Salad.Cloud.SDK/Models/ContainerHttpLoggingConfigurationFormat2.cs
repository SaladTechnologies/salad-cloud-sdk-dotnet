using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The format in which logs will be delivered</summary>
public record ContainerHttpLoggingConfigurationFormat2 : ValueEnum<string>
{
    internal ContainerHttpLoggingConfigurationFormat2(string value)
        : base(value) { }

    public ContainerHttpLoggingConfigurationFormat2()
        : base("json") { }

    public static ContainerHttpLoggingConfigurationFormat2 Json = new("json");
    public static ContainerHttpLoggingConfigurationFormat2 JsonLines = new("json_lines");
}
