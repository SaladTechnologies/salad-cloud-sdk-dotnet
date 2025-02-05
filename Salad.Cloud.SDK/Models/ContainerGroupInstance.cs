using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents the details of a single container group instance</summary>
public record ContainerGroupInstance(
    /// <value>The unique instance ID</value>
    [property: JsonPropertyName("instance_id")]
        string InstanceId,
    /// <value>The machine ID</value>
    [property: JsonPropertyName("machine_id")]
        string MachineId,
    /// <value>The state of the container group instance</value>
    [property: JsonPropertyName("state")]
        State State1,
    /// <value>The UTC date & time when the workload on this machine transitioned to the current state</value>
    [property: JsonPropertyName("update_time")]
        string UpdateTime,
    /// <value>The version of the running container group</value>
    [property: JsonPropertyName("version")]
        long Version,
    /// <value>Specifies whether the container group instance is currently passing its readiness check. If no readiness probe is defined, is true once fully started.</value>
    [property:
        JsonPropertyName("ready"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Ready = null,
    /// <value>Specifies whether the container group instance passed its startup probe. Is always true when no startup probe is defined.</value>
    [property:
        JsonPropertyName("started"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Started = null
);
