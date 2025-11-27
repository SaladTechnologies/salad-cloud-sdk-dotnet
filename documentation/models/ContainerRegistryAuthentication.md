# ContainerRegistryAuthentication

Authentication configuration for various container registry types, including AWS ECR, Docker Hub, GCP GAR, GCP GCR, and basic authentication.

**Properties**

| Name      | Type                                                                                    | Required | Description                                                                 |
| :-------- | :-------------------------------------------------------------------------------------- | :------- | :-------------------------------------------------------------------------- |
| AwsEcr    | [ContainerRegistryAuthenticationAwsEcr](ContainerRegistryAuthenticationAwsEcr.md)       | ❌       | Authentication details for AWS Elastic Container Registry (ECR)             |
| Basic     | [ContainerRegistryAuthenticationBasic](ContainerRegistryAuthenticationBasic.md)         | ❌       | Basic username and password authentication for generic container registries |
| DockerHub | [ContainerRegistryAuthenticationDockerHub](ContainerRegistryAuthenticationDockerHub.md) | ❌       | Authentication details for Docker Hub registry                              |
| GcpGar    | [ContainerRegistryAuthenticationGcpGar](ContainerRegistryAuthenticationGcpGar.md)       | ❌       | Authentication details for Google Artifact Registry (GAR)                   |
| GcpGcr    | [ContainerRegistryAuthenticationGcpGcr](ContainerRegistryAuthenticationGcpGcr.md)       | ❌       | Authentication details for Google Container Registry (GCR)                  |
