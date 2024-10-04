using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a request to update a container group</summary>
public record UpdateContainerGroup(
    [property: JsonPropertyName("display_name")] string? DisplayName = null,
    /// <value>Represents an update container object</value>
    [property: JsonPropertyName("container")]
        UpdateContainer? Container = null,
    [property: JsonPropertyName("replicas")] long? Replicas = null,
    /// <value>List of countries nodes must be located in. Remove this field to permit nodes from any country.</value>
    [property: JsonPropertyName("country_codes")]
        List<CountryCode>? CountryCodes = null,
    /// <value>Represents update container group networking parameters</value>
    [property:
        JsonPropertyName("networking"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        UpdateContainerGroupNetworking? Networking = null,
    /// <value>Represents the container group liveness probe</value>
    [property: JsonPropertyName("liveness_probe")]
        ContainerGroupLivenessProbe? LivenessProbe = null,
    /// <value>Represents the container group readiness probe</value>
    [property: JsonPropertyName("readiness_probe")]
        ContainerGroupReadinessProbe? ReadinessProbe = null,
    /// <value>Represents the container group startup probe</value>
    [property: JsonPropertyName("startup_probe")]
        ContainerGroupStartupProbe? StartupProbe = null,
    /// <value>Represents the autoscaling rules for a queue</value>
    [property: JsonPropertyName("queue_autoscaler")]
        QueueAutoscaler? QueueAutoscaler = null
);
