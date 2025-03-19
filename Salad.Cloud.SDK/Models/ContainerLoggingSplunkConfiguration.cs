using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Configuration settings for forwarding container logs to a Splunk instance.</summary>
public record ContainerLoggingSplunkConfiguration(
    /// <value>The URL of the Splunk HTTP Event Collector (HEC) endpoint.</value>
    [property: JsonPropertyName("host")]
        string Host,
    /// <value>The authentication token required to send data to the Splunk HEC endpoint.</value>
    [property: JsonPropertyName("token")]
        string Token
);
