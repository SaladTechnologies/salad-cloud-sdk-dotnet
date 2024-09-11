using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents the container group readiness probe</summary>
public record ContainerGroupReadinessProbe(
    [property: JsonPropertyName("initial_delay_seconds")] long InitialDelaySeconds,
    [property: JsonPropertyName("period_seconds")] long PeriodSeconds,
    [property: JsonPropertyName("timeout_seconds")] long TimeoutSeconds,
    [property: JsonPropertyName("success_threshold")] long SuccessThreshold,
    [property: JsonPropertyName("failure_threshold")] long FailureThreshold,
    [property: JsonPropertyName("tcp"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        ContainerGroupProbeTcp? Tcp = null,
    [property:
        JsonPropertyName("http"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerGroupProbeHttp? Http = null,
    [property:
        JsonPropertyName("grpc"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerGroupProbeGrpc? Grpc = null,
    [property:
        JsonPropertyName("exec"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerGroupProbeExec? Exec = null
);
