using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a request to create a container group, which manages a collection of container instances with shared configuration and scaling policies</summary>
public record ContainerGroupCreationRequest(
    /// <value>Determines whether the container group should start automatically when created (true) or remain stopped until manually started (false)</value>
    [property: JsonPropertyName("autostart_policy")]
        bool AutostartPolicy,
    /// <value>Configuration for creating a container within a container group. Defines the container image, resource requirements, environment variables, and other settings needed to deploy and run the container.</value>
    [property: JsonPropertyName("container")]
        ContainerConfiguration Container,
    /// <value>Unique identifier for the container group that must follow DNS naming conventions (lowercase alphanumeric with hyphens)</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>Number of container instances to deploy and maintain for this container group</value>
    [property: JsonPropertyName("replicas")]
        long Replicas,
    /// <value>Specifies the policy for restarting containers when they exit or fail.</value>
    [property: JsonPropertyName("restart_policy")]
        ContainerRestartPolicy RestartPolicy,
    /// <value>List of countries nodes must be located in. Remove this field to permit nodes from any country.</value>
    [property:
        JsonPropertyName("country_codes"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<CountryCode>? CountryCodes = null,
    /// <value>Human-readable name for the container group that can include spaces and special characters, used for display purposes</value>
    [property:
        JsonPropertyName("display_name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? DisplayName = null,
    /// <value>Defines a liveness probe for container groups that determines when to restart a container if it becomes unhealthy</value>
    [property: JsonPropertyName("liveness_probe")]
        ContainerGroupLivenessProbe? LivenessProbe = null,
    /// <value>Network configuration for container groups specifying connectivity parameters, including authentication, protocol, and timeout settings</value>
    [property:
        JsonPropertyName("networking"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        CreateContainerGroupNetworking? Networking = null,
    /// <value>Defines configuration for automatically scaling container instances based on queue length. The autoscaler monitors a queue and adjusts the number of running replicas to maintain the desired queue length.</value>
    [property:
        JsonPropertyName("queue_autoscaler"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        QueueBasedAutoscalerConfiguration? QueueAutoscaler = null,
    /// <value>Configuration for connecting a container group to a message queue system, enabling asynchronous communication between services.</value>
    [property:
        JsonPropertyName("queue_connection"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerGroupQueueConnection? QueueConnection = null,
    /// <value>Defines how to check if a container is ready to serve traffic. The readiness probe determines whether the container's application is ready to accept traffic. If the readiness probe fails, the container is considered not ready and traffic will not be sent to it.</value>
    [property: JsonPropertyName("readiness_probe")]
        ContainerGroupReadinessProbe? ReadinessProbe = null,
    /// <value>List of scaling action configurations</value>
    [property:
        JsonPropertyName("scaling-actions"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ContainerGroupScalingAction>? ScalingActions = null,
    /// <value>Indicates if scheduled scaling is enabled</value>
    [property:
        JsonPropertyName("scheduled-scaling-enabled"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? ScheduledScalingEnabled = null,
    /// <value>Defines a probe that checks if a container application has started successfully. Startup probes help prevent applications from being prematurely marked as unhealthy during initialization. The probe can use HTTP requests, TCP connections, gRPC calls, or shell commands to determine startup status.</value>
    [property: JsonPropertyName("startup_probe")]
        ContainerGroupStartupProbe? StartupProbe = null
);
