using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Defines how to check if a container is ready to serve traffic. The readiness probe determines whether the container's application is ready to accept traffic. If the readiness probe fails, the container is considered not ready and traffic will not be sent to it.</summary>
public record ContainerGroupReadinessProbe(
    /// <value>The number of consecutive failures required to consider the probe failed. After this many consecutive failures, the container is marked as not ready.</value>
    [property: JsonPropertyName("failure_threshold")]
        long FailureThreshold,
    /// <value>The time in seconds to wait after the container starts before initiating the first probe. This allows time for the application to initialize before being tested.</value>
    [property: JsonPropertyName("initial_delay_seconds")]
        long InitialDelaySeconds,
    /// <value>How frequently (in seconds) the probe should be executed during the container's lifetime. Specifies the interval between consecutive probe executions.</value>
    [property: JsonPropertyName("period_seconds")]
        long PeriodSeconds,
    /// <value>The minimum consecutive successes required to consider the probe successful after it has failed. Defines how many successful probe results are needed to transition from failure to success.</value>
    [property: JsonPropertyName("success_threshold")]
        long SuccessThreshold,
    /// <value>The maximum time in seconds that the probe has to complete. If the probe doesn't return a result before the timeout, it's considered failed.</value>
    [property: JsonPropertyName("timeout_seconds")]
        long TimeoutSeconds,
    /// <value>Defines the exec action for a probe in a container group. This is used to execute a command inside a container for health checks.</value>
    [property:
        JsonPropertyName("exec"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerGroupProbeExec? Exec = null,
    /// <value>Configuration for gRPC-based health probes in container groups, used to determine container health status.</value>
    [property:
        JsonPropertyName("grpc"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerGroupGRpcProbe? Grpc = null,
    /// <value>Defines HTTP probe configuration for container health checks within a container group.</value>
    [property:
        JsonPropertyName("http"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerGroupHttpProbeConfiguration? Http = null,
    /// <value>Configuration for a TCP probe used to check container health via network connectivity.</value>
    [property:
        JsonPropertyName("tcp"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerGroupTcpProbe? Tcp = null
);
