using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Defines a probe that checks if a container application has started successfully. Startup probes help prevent applications from being prematurely marked as unhealthy during initialization. The probe can use HTTP requests, TCP connections, gRPC calls, or shell commands to determine startup status.</summary>
public record ContainerGroupStartupProbe(
    /// <value>Number of times the probe must fail before considering the container not started</value>
    [property: JsonPropertyName("failure_threshold")]
        long FailureThreshold,
    /// <value>Number of seconds to wait after container startup before the first probe is executed</value>
    [property: JsonPropertyName("initial_delay_seconds")]
        long InitialDelaySeconds,
    /// <value>How frequently (in seconds) to perform the probe</value>
    [property: JsonPropertyName("period_seconds")]
        long PeriodSeconds,
    /// <value>Minimum consecutive successes required for the probe to be considered successful</value>
    [property: JsonPropertyName("success_threshold")]
        long SuccessThreshold,
    /// <value>Maximum time (in seconds) to wait for a probe response before considering it failed</value>
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
