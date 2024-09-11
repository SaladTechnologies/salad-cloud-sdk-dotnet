using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

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
