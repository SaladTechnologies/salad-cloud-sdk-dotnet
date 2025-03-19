using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Authentication details for Google Artifact Registry (GAR)</summary>
public record ContainerRegistryAuthenticationGcpGar(
    /// <value>GCP service account key in JSON format for GAR authentication</value>
    [property: JsonPropertyName("service_key")]
        string ServiceKey
);
