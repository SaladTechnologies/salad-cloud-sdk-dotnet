using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Authentication details for AWS Elastic Container Registry (ECR)</summary>
public record ContainerRegistryAuthenticationAwsEcr(
    /// <value>AWS access key ID used for ECR authentication</value>
    [property: JsonPropertyName("access_key_id")]
        string AccessKeyId,
    /// <value>AWS secret access key used for ECR authentication</value>
    [property: JsonPropertyName("secret_access_key")]
        string SecretAccessKey
);
