using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>The state of the container group instance</summary>
public record TheContainerGroupInstanceState : ValueEnum<string>
{
    internal TheContainerGroupInstanceState(string value)
        : base(value) { }

    public TheContainerGroupInstanceState()
        : base("allocating") { }

    public static TheContainerGroupInstanceState Allocating = new("allocating");
    public static TheContainerGroupInstanceState Downloading = new("downloading");
    public static TheContainerGroupInstanceState Creating = new("creating");
    public static TheContainerGroupInstanceState Running = new("running");
    public static TheContainerGroupInstanceState Stopping = new("stopping");
}
