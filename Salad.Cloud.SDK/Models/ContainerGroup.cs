using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>A container group definition that represents a scalable set of identical containers running as a distributed service</summary>
public record ContainerGroup(
    /// <value>Defines whether containers in this group should automatically start when deployed (true) or require manual starting (false)</value>
    [property: JsonPropertyName("autostart_policy")]
        bool AutostartPolicy,
    /// <value>Represents a container with its configuration and resource requirements.</value>
    [property: JsonPropertyName("container")]
        Container Container,
    /// <value>List of country codes where container instances are permitted to run. When not specified or empty, containers may run in any available region.</value>
    [property: JsonPropertyName("country_codes")]
        List<CountryCode> CountryCodes,
    /// <value>ISO 8601 timestamp when this container group was initially created</value>
    [property: JsonPropertyName("create_time")]
        string CreateTime,
    /// <value>Represents the operational state of a container group during its lifecycle, including timing information, status, and instance distribution metrics. This state captures the current execution status, start and finish times, and provides visibility into the operational health across instances.</value>
    [property: JsonPropertyName("current_state")]
        ContainerGroupState CurrentState,
    /// <value>The display-friendly name of the resource.</value>
    [property: JsonPropertyName("display_name")]
        string DisplayName,
    /// <value>The container group identifier.</value>
    [property: JsonPropertyName("id")]
        string Id,
    /// <value>The container group name.</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>The organization name.</value>
    [property: JsonPropertyName("organization_name")]
        string OrganizationName,
    /// <value>Indicates whether a configuration change has been requested but not yet applied to all containers in the group</value>
    [property: JsonPropertyName("pending_change")]
        bool PendingChange,
    /// <value>Specifies the priority level for container group execution, which determines resource allocation and scheduling precedence.</value>
    [property: JsonPropertyName("priority")]
        ContainerGroupPriority Priority,
    /// <value>The project name.</value>
    [property: JsonPropertyName("project_name")]
        string ProjectName,
    /// <value>The container group replicas.</value>
    [property: JsonPropertyName("replicas")]
        long Replicas,
    /// <value>Specifies the policy for restarting containers when they exit or fail.</value>
    [property: JsonPropertyName("restart_policy")]
        ContainerRestartPolicy RestartPolicy,
    /// <value>ISO 8601 timestamp when this container group was last updated</value>
    [property: JsonPropertyName("update_time")]
        string UpdateTime,
    /// <value>Incremental version number that increases with each configuration change to the container group</value>
    [property: JsonPropertyName("version")]
        long Version,
    /// <value>Defines a liveness probe for container groups that determines when to restart a container if it becomes unhealthy</value>
    [property: JsonPropertyName("liveness_probe")]
        ContainerGroupLivenessProbe? LivenessProbe = null,
    /// <value>Network configuration for container groups that defines connectivity, routing, and access control settings</value>
    [property:
        JsonPropertyName("networking"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerGroupNetworkingConfiguration? Networking = null,
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
    [property:
        JsonPropertyName("readme"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Readme = null,
    /// <value>Defines a probe that checks if a container application has started successfully. Startup probes help prevent applications from being prematurely marked as unhealthy during initialization. The probe can use HTTP requests, TCP connections, gRPC calls, or shell commands to determine startup status.</value>
    [property: JsonPropertyName("startup_probe")]
        ContainerGroupStartupProbe? StartupProbe = null
);
