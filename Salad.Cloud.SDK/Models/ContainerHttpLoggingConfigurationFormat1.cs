using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The format in which logs will be delivered</summary>
public record ContainerHttpLoggingConfigurationFormat1 : ValueEnum<string>
{
    internal ContainerHttpLoggingConfigurationFormat1(string value)
        : base(value) { }

    public ContainerHttpLoggingConfigurationFormat1()
        : base("json") { }

    public static ContainerHttpLoggingConfigurationFormat1 Json = new("json");
    public static ContainerHttpLoggingConfigurationFormat1 JsonLines = new("json_lines");
}
