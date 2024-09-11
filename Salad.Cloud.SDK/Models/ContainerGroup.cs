using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a container group</summary>
public record ContainerGroup(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("display_name")] string DisplayName,
    /// <value>Represents a container</value>
    [property: JsonPropertyName("container")]
        Container Container,
    [property: JsonPropertyName("autostart_policy")] bool AutostartPolicy,
    [property: JsonPropertyName("restart_policy")] ContainerRestartPolicy RestartPolicy,
    [property: JsonPropertyName("replicas")] long Replicas,
    /// <value>Represents a container group state</value>
    [property: JsonPropertyName("current_state")]
        ContainerGroupState CurrentState,
    [property: JsonPropertyName("create_time")] string CreateTime,
    [property: JsonPropertyName("update_time")] string UpdateTime,
    [property: JsonPropertyName("pending_change")] bool PendingChange,
    [property: JsonPropertyName("version")] long Version,
    /// <value>List of countries nodes must be located in. Remove this field to permit nodes from any country.</value>
    [property:
        JsonPropertyName("country_codes"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<CountryCode>? CountryCodes = null,
    /// <value>Represents container group networking parameters</value>
    [property: JsonPropertyName("networking")]
        ContainerGroupNetworking? Networking = null,
    /// <value>Represents the container group liveness probe</value>
    [property: JsonPropertyName("liveness_probe")]
        ContainerGroupLivenessProbe? LivenessProbe = null,
    /// <value>Represents the container group readiness probe</value>
    [property: JsonPropertyName("readiness_probe")]
        ContainerGroupReadinessProbe? ReadinessProbe = null,
    /// <value>Represents the container group startup probe</value>
    [property: JsonPropertyName("startup_probe")]
        ContainerGroupStartupProbe? StartupProbe = null,
    /// <value>Represents container group queue connection</value>
    [property: JsonPropertyName("queue_connection")]
        ContainerGroupQueueConnection? QueueConnection = null
);
