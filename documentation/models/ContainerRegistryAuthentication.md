# ContainerRegistryAuthentication

Authentication configuration for various container registry types, including AWS ECR, Docker Hub, GCP GAR, GCP GCR, and basic authentication.

**Properties**

| Name      | Type                                     | Required | Description                                                                 |
| :-------- | :--------------------------------------- | :------- | :-------------------------------------------------------------------------- |
| AwsEcr    | ContainerRegistryAuthenticationAwsEcr    | ❌       | Authentication details for AWS Elastic Container Registry (ECR)             |
| Basic     | ContainerRegistryAuthenticationBasic     | ❌       | Basic username and password authentication for generic container registries |
| DockerHub | ContainerRegistryAuthenticationDockerHub | ❌       | Authentication details for Docker Hub registry                              |
| GcpGar    | ContainerRegistryAuthenticationGcpGar    | ❌       | Authentication details for Google Artifact Registry (GAR)                   |
| GcpGcr    | ContainerRegistryAuthenticationGcpGcr    | ❌       | Authentication details for Google Container Registry (GCR)                  |
