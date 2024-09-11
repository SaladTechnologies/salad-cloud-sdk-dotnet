using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents an update container object</summary>
public record UpdateContainer(
    [property: JsonPropertyName("image")] string? Image = null,
    [property: JsonPropertyName("resources")] UpdateContainer.Resources? Resources_ = null,
    /// <value>Pass a command (and optional arguments) to override the ENTRYPOINT and CMD of a container image.</value>
    [property: JsonPropertyName("command")]
        List<string>? Command = null,
    [property: JsonPropertyName("priority")] ContainerGroupPriority? Priority = null,
    [property:
        JsonPropertyName("environment_variables"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? EnvironmentVariables = null,
    [property: JsonPropertyName("logging")] UpdateContainer.UpdateContainerLogging? Logging = null,
    [property: JsonPropertyName("registry_authentication")]
        UpdateContainer.UpdateContainerRegistryAuthentication? RegistryAuthentication = null
)
{
    public record Resources(
        [property: JsonPropertyName("cpu")] long? Cpu = null,
        [property: JsonPropertyName("memory")] long? Memory = null,
        [property: JsonPropertyName("gpu_classes")] List<string>? GpuClasses = null,
        [property: JsonPropertyName("storage_amount")] long? StorageAmount = null
    );

    public record UpdateContainerLogging(
        [property: JsonPropertyName("axiom")] UpdateContainerLogging.LoggingAxiom3? Axiom = null,
        [property: JsonPropertyName("datadog")]
            UpdateContainerLogging.LoggingDatadog3? Datadog = null,
        [property: JsonPropertyName("new_relic")]
            UpdateContainerLogging.LoggingNewRelic3? NewRelic = null,
        [property: JsonPropertyName("splunk")] UpdateContainerLogging.LoggingSplunk3? Splunk = null,
        [property: JsonPropertyName("tcp")] UpdateContainerLogging.LoggingTcp3? Tcp = null,
        [property: JsonPropertyName("http")] UpdateContainerLogging.LoggingHttp3? Http = null
    )
    {
        public record LoggingAxiom3(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("api_token")] string ApiToken,
            [property: JsonPropertyName("dataset")] string Dataset
        );

        public record LoggingDatadog3(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("api_key")] string ApiKey,
            [property: JsonPropertyName("tags")] List<LoggingDatadog3.DatadogTags3>? Tags = null
        )
        {
            public record DatadogTags3(
                [property: JsonPropertyName("name")] string Name,
                [property: JsonPropertyName("value")] string Value
            );
        }

        public record LoggingNewRelic3(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("ingestion_key")] string IngestionKey
        );

        public record LoggingSplunk3(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("token")] string Token
        );

        public record LoggingTcp3(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("port")] long Port
        );

        public record LoggingHttp3(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("port")] long Port,
            [property: JsonPropertyName("format")] LoggingHttp3.HttpFormat3 Format,
            [property: JsonPropertyName("compression")] LoggingHttp3.HttpCompression3 Compression,
            [property: JsonPropertyName("user")] string? User = null,
            [property: JsonPropertyName("password")] string? Password = null,
            [property: JsonPropertyName("path")] string? Path = null,
            [property: JsonPropertyName("headers")] List<LoggingHttp3.HttpHeaders4>? Headers = null
        )
        {
            public record HttpFormat3 : ValueEnum<string>
            {
                internal HttpFormat3(string value)
                    : base(value) { }

                public HttpFormat3()
                    : base("json") { }

                public static HttpFormat3 Json = new("json");
                public static HttpFormat3 JsonLines = new("json_lines");
            }

            public record HttpHeaders4(
                [property: JsonPropertyName("name")] string Name,
                [property: JsonPropertyName("value")] string Value
            );

            public record HttpCompression3 : ValueEnum<string>
            {
                internal HttpCompression3(string value)
                    : base(value) { }

                public HttpCompression3()
                    : base("none") { }

                public static HttpCompression3 None = new("none");
                public static HttpCompression3 Gzip = new("gzip");
            }
        }
    }

    public record UpdateContainerRegistryAuthentication(
        [property: JsonPropertyName("basic")]
            UpdateContainerRegistryAuthentication.RegistryAuthenticationBasic2? Basic = null,
        [property: JsonPropertyName("gcp_gcr")]
            UpdateContainerRegistryAuthentication.RegistryAuthenticationGcpGcr2? GcpGcr = null,
        [property: JsonPropertyName("aws_ecr")]
            UpdateContainerRegistryAuthentication.RegistryAuthenticationAwsEcr2? AwsEcr = null,
        [property: JsonPropertyName("docker_hub")]
            UpdateContainerRegistryAuthentication.RegistryAuthenticationDockerHub2? DockerHub =
            null,
        [property: JsonPropertyName("gcp_gar")]
            UpdateContainerRegistryAuthentication.RegistryAuthenticationGcpGar2? GcpGar = null
    )
    {
        public record RegistryAuthenticationBasic2(
            [property: JsonPropertyName("username")] string Username,
            [property: JsonPropertyName("password")] string Password
        );

        public record RegistryAuthenticationGcpGcr2(
            [property: JsonPropertyName("service_key")] string ServiceKey
        );

        public record RegistryAuthenticationAwsEcr2(
            [property: JsonPropertyName("access_key_id")] string AccessKeyId,
            [property: JsonPropertyName("secret_access_key")] string SecretAccessKey
        );

        public record RegistryAuthenticationDockerHub2(
            [property: JsonPropertyName("username")] string Username,
            [property: JsonPropertyName("personal_access_token")] string PersonalAccessToken
        );

        public record RegistryAuthenticationGcpGar2(
            [property: JsonPropertyName("service_key")] string ServiceKey
        );
    }
}
