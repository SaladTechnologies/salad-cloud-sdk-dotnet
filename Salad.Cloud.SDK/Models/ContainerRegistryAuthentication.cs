using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Authentication configuration for various container registry types, including AWS ECR, Docker Hub, GCP GAR, GCP GCR, and basic authentication.</summary>
public record ContainerRegistryAuthentication(
    /// <value>Authentication details for AWS Elastic Container Registry (ECR)</value>
    [property: JsonPropertyName("aws_ecr")]
        ContainerRegistryAuthenticationAwsEcr? AwsEcr = null,
    /// <value>Basic username and password authentication for generic container registries</value>
    [property:
        JsonPropertyName("basic"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerRegistryAuthenticationBasic? Basic = null,
    /// <value>Authentication details for Docker Hub registry</value>
    [property:
        JsonPropertyName("docker_hub"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerRegistryAuthenticationDockerHub? DockerHub = null,
    /// <value>Authentication details for Google Artifact Registry (GAR)</value>
    [property:
        JsonPropertyName("gcp_gar"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerRegistryAuthenticationGcpGar? GcpGar = null,
    /// <value>Authentication details for Google Container Registry (GCR)</value>
    [property:
        JsonPropertyName("gcp_gcr"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerRegistryAuthenticationGcpGcr? GcpGcr = null
);
