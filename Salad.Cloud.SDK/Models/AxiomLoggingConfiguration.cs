using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Configuration settings for integrating container logs with the Axiom logging service. When specified, container logs will be forwarded to the Axiom instance defined by these parameters.</summary>
public record AxiomLoggingConfiguration(
    /// <value>The Axiom host URL where logs will be sent (e.g. logs.axiom.co)</value>
    [property: JsonPropertyName("host")]
        string Host,
    /// <value>Authentication token for the Axiom API with appropriate write permissions</value>
    [property: JsonPropertyName("api_token")]
        string ApiToken,
    /// <value>Name of the Axiom dataset where the container logs will be stored and indexed</value>
    [property: JsonPropertyName("dataset")]
        string Dataset
);
