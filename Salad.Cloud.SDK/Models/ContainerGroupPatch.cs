using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a request to update a container group</summary>
public record ContainerGroupPatch(
    /// <value>The display name for the container group. If null is provided, the display name will be set to the container group name.</value>
    [property: JsonPropertyName("display_name")]
        string? DisplayName = null,
    /// <value>Represents an update container object</value>
    [property: JsonPropertyName("container")]
        UpdateContainer? Container = null,
    /// <value>The desired number of instances for your container group deployment.</value>
    [property: JsonPropertyName("replicas")]
        long? Replicas = null,
    /// <value>List of countries nodes must be located in. Remove this field to permit nodes from any country.</value>
    [property: JsonPropertyName("country_codes")]
        List<CountryCode>? CountryCodes = null,
    /// <value>Represents update container group networking parameters</value>
    [property:
        JsonPropertyName("networking"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        UpdateContainerGroupNetworking? Networking = null,
    /// <value>Defines a liveness probe for container groups that determines when to restart a container if it becomes unhealthy</value>
    [property: JsonPropertyName("liveness_probe")]
        ContainerGroupLivenessProbe? LivenessProbe = null,
    /// <value>Defines how to check if a container is ready to serve traffic. The readiness probe determines whether the container's application is ready to accept traffic. If the readiness probe fails, the container is considered not ready and traffic will not be sent to it.</value>
    [property: JsonPropertyName("readiness_probe")]
        ContainerGroupReadinessProbe? ReadinessProbe = null,
    /// <value>Defines a probe that checks if a container application has started successfully. Startup probes help prevent applications from being prematurely marked as unhealthy during initialization. The probe can use HTTP requests, TCP connections, gRPC calls, or shell commands to determine startup status.</value>
    [property: JsonPropertyName("startup_probe")]
        ContainerGroupStartupProbe? StartupProbe = null,
    /// <value>Defines configuration for automatically scaling container instances based on queue length. The autoscaler monitors a queue and adjusts the number of running replicas to maintain the desired queue length.</value>
    [property:
        JsonPropertyName("queue_autoscaler"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        QueueBasedAutoscalerConfiguration? QueueAutoscaler = null
);
