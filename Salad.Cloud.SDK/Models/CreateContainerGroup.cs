using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a request to create a container group</summary>
public record CreateContainerGroup(
    [property: JsonPropertyName("name")] string Name,
    /// <value>Represents a container</value>
    [property: JsonPropertyName("container")]
        CreateContainer Container,
    [property: JsonPropertyName("autostart_policy")] bool AutostartPolicy,
    [property: JsonPropertyName("restart_policy")] ContainerRestartPolicy RestartPolicy,
    [property: JsonPropertyName("replicas")] long Replicas,
    [property: JsonPropertyName("display_name")] string? DisplayName = null,
    /// <value>List of countries nodes must be located in. Remove this field to permit nodes from any country.</value>
    [property:
        JsonPropertyName("country_codes"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<CountryCode>? CountryCodes = null,
    /// <value>Represents container group networking parameters</value>
    [property: JsonPropertyName("networking")]
        CreateContainerGroupNetworking? Networking = null,
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
