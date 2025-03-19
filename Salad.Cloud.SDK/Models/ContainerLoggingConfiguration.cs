using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Configuration options for directing container logs to a logging provider. This schema enables you to specify a single logging destination for container output, supporting monitoring, debugging, and analytics use cases. Each provider has its own configuration parameters defined in the referenced schemas. Only one logging provider can be selected at a time.</summary>
public record ContainerLoggingConfiguration(
    /// <value>Configuration settings for integrating container logs with the Axiom logging service. When specified, container logs will be forwarded to the Axiom instance defined by these parameters.</value>
    [property:
        JsonPropertyName("axiom"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AxiomLoggingConfiguration? Axiom = null,
    /// <value>Configuration for forwarding container logs to Datadog monitoring service.</value>
    [property:
        JsonPropertyName("datadog"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        DatadogLoggingConfiguration? Datadog = null,
    /// <value>Configuration for sending container logs to an HTTP endpoint. Defines how logs are formatted, compressed, and transmitted.</value>
    [property:
        JsonPropertyName("http"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerHttpLoggingConfiguration? Http = null,
    /// <value>Configuration for sending container logs to New Relic's log management platform.</value>
    [property:
        JsonPropertyName("new_relic"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        NewRelicLoggingConfiguration? NewRelic = null,
    /// <value>Configuration settings for forwarding container logs to a Splunk instance.</value>
    [property:
        JsonPropertyName("splunk"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerLoggingSplunkConfiguration? Splunk = null,
    /// <value>Configuration for forwarding container logs to a remote TCP endpoint</value>
    [property:
        JsonPropertyName("tcp"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        TcpLoggingConfiguration? Tcp = null
);
