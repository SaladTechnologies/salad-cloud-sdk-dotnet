using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Specifies the priority level for container group execution, which determines resource allocation and scheduling precedence.</summary>
public record ContainerGroupPriority : ValueEnum<string>
{
    internal ContainerGroupPriority(string value)
        : base(value) { }

    public ContainerGroupPriority()
        : base("high") { }

    public static ContainerGroupPriority High = new("high");
    public static ContainerGroupPriority Medium = new("medium");
    public static ContainerGroupPriority Low = new("low");
    public static ContainerGroupPriority Batch = new("batch");
}
