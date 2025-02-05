using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record CreateContainerRegistryAuthentication(
    [property: JsonPropertyName("basic")] RegistryAuthenticationBasic1? Basic = null,
    [property: JsonPropertyName("gcp_gcr")] RegistryAuthenticationGcpGcr1? GcpGcr = null,
    [property: JsonPropertyName("aws_ecr")] RegistryAuthenticationAwsEcr1? AwsEcr = null,
    [property: JsonPropertyName("docker_hub")] RegistryAuthenticationDockerHub1? DockerHub = null,
    [property: JsonPropertyName("gcp_gar")] RegistryAuthenticationGcpGar1? GcpGar = null
);
