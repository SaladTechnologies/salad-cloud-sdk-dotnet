using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record UpdateContainerRegistryAuthentication(
    [property: JsonPropertyName("basic")] RegistryAuthenticationBasic2? Basic = null,
    [property: JsonPropertyName("gcp_gcr")] RegistryAuthenticationGcpGcr2? GcpGcr = null,
    [property: JsonPropertyName("aws_ecr")] RegistryAuthenticationAwsEcr2? AwsEcr = null,
    [property: JsonPropertyName("docker_hub")] RegistryAuthenticationDockerHub2? DockerHub = null,
    [property: JsonPropertyName("gcp_gar")] RegistryAuthenticationGcpGar2? GcpGar = null
);
