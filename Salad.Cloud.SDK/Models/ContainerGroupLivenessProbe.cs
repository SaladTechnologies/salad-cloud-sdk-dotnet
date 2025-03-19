using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Defines a liveness probe for container groups that determines when to restart a container if it becomes unhealthy</summary>
public record ContainerGroupLivenessProbe(
    /// <value>Number of consecutive failures required to consider the probe as failed</value>
    [property: JsonPropertyName("failure_threshold")]
        long FailureThreshold,
    /// <value>Number of seconds to wait after container start before initiating liveness probes</value>
    [property: JsonPropertyName("initial_delay_seconds")]
        long InitialDelaySeconds,
    /// <value>Frequency in seconds at which the probe should be executed</value>
    [property: JsonPropertyName("period_seconds")]
        long PeriodSeconds,
    /// <value>Number of consecutive successes required to consider the probe successful</value>
    [property: JsonPropertyName("success_threshold")]
        long SuccessThreshold,
    /// <value>Number of seconds after which the probe times out if no response is received</value>
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
