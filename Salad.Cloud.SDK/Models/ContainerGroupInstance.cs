using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>A Container Group Instance represents a running instance of a container group on a specific machine. It provides information about the execution state, readiness, and version of the deployed container group.</summary>
public record ContainerGroupInstance(
    /// <value>The container group instance identifier.</value>
    [property: JsonPropertyName("id")]
        string Id,
    /// <value>The container group machine identifier.</value>
    [property: JsonPropertyName("machine_id")]
        string MachineId,
    /// <value>The state of the container group instance</value>
    [property: JsonPropertyName("state")]
        TheContainerGroupInstanceState State,
    /// <value>The UTC timestamp when the container group instance last changed its state. This helps track the lifecycle and state transitions of the instance.</value>
    [property: JsonPropertyName("update_time")]
        string UpdateTime,
    /// <value>The version of the container group definition currently running on this instance. Used to track deployment and update progress across the container group fleet.</value>
    [property: JsonPropertyName("version")]
        long Version,
    /// <value>Indicates whether the container group instance is currently passing its readiness checks and is able to receive traffic or perform its intended function. If no readiness probe is defined, this will be true once the instance is fully started.</value>
    [property:
        JsonPropertyName("ready"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Ready = null,
    /// <value>Indicates whether the container group instance has successfully completed its startup sequence and passed any configured startup probes. This will always be true when no startup probe is defined for the container group.</value>
    [property:
        JsonPropertyName("started"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Started = null,
    /// <value>The cost of deleting the container group instance</value>
    [property:
        JsonPropertyName("deletion_cost"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? DeletionCost = null
);
