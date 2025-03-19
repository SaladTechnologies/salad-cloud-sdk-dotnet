using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Authentication details for Google Container Registry (GCR)</summary>
public record ContainerRegistryAuthenticationGcpGcr(
    /// <value>GCP service account key in JSON format for GCR authentication</value>
    [property: JsonPropertyName("service_key")]
        string ServiceKey
);
