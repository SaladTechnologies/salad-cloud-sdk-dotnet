using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a container</summary>
public record CreateContainer(
    [property: JsonPropertyName("image")] string Image,
    /// <value>Represents a container resource requirements</value>
    [property: JsonPropertyName("resources")]
        ContainerResourceRequirements Resources,
    /// <value>Pass a command (and optional arguments) to override the ENTRYPOINT and CMD of a container image.</value>
    [property: JsonPropertyName("command")]
        List<string>? Command = null,
    [property: JsonPropertyName("priority")] ContainerGroupPriority? Priority = null,
    [property:
        JsonPropertyName("environment_variables"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? EnvironmentVariables = null,
    [property: JsonPropertyName("logging")] CreateContainer.CreateContainerLogging? Logging = null,
    [property: JsonPropertyName("registry_authentication")]
        CreateContainer.CreateContainerRegistryAuthentication? RegistryAuthentication = null
)
{
    public record CreateContainerLogging(
        [property: JsonPropertyName("axiom")] CreateContainerLogging.LoggingAxiom2? Axiom = null,
        [property: JsonPropertyName("datadog")]
            CreateContainerLogging.LoggingDatadog2? Datadog = null,
        [property: JsonPropertyName("new_relic")]
            CreateContainerLogging.LoggingNewRelic2? NewRelic = null,
        [property: JsonPropertyName("splunk")] CreateContainerLogging.LoggingSplunk2? Splunk = null,
        [property: JsonPropertyName("tcp")] CreateContainerLogging.LoggingTcp2? Tcp = null,
        [property: JsonPropertyName("http")] CreateContainerLogging.LoggingHttp2? Http = null
    )
    {
        public record LoggingAxiom2(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("api_token")] string ApiToken,
            [property: JsonPropertyName("dataset")] string Dataset
        );

        public record LoggingDatadog2(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("api_key")] string ApiKey,
            [property: JsonPropertyName("tags")] List<LoggingDatadog2.DatadogTags2>? Tags = null
        )
        {
            public record DatadogTags2(
                [property: JsonPropertyName("name")] string Name,
                [property: JsonPropertyName("value")] string Value
            );
        }

        public record LoggingNewRelic2(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("ingestion_key")] string IngestionKey
        );

        public record LoggingSplunk2(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("token")] string Token
        );

        public record LoggingTcp2(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("port")] long Port
        );

        public record LoggingHttp2(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("port")] long Port,
            [property: JsonPropertyName("format")] LoggingHttp2.HttpFormat2 Format,
            [property: JsonPropertyName("compression")] LoggingHttp2.HttpCompression2 Compression,
            [property: JsonPropertyName("user")] string? User = null,
            [property: JsonPropertyName("password")] string? Password = null,
            [property: JsonPropertyName("path")] string? Path = null,
            [property: JsonPropertyName("headers")] List<LoggingHttp2.HttpHeaders3>? Headers = null
        )
        {
            public record HttpFormat2 : ValueEnum<string>
            {
                internal HttpFormat2(string value)
                    : base(value) { }

                public HttpFormat2()
                    : base("json") { }

                public static HttpFormat2 Json = new("json");
                public static HttpFormat2 JsonLines = new("json_lines");
            }

            public record HttpHeaders3(
                [property: JsonPropertyName("name")] string Name,
                [property: JsonPropertyName("value")] string Value
            );

            public record HttpCompression2 : ValueEnum<string>
            {
                internal HttpCompression2(string value)
                    : base(value) { }

                public HttpCompression2()
                    : base("none") { }

                public static HttpCompression2 None = new("none");
                public static HttpCompression2 Gzip = new("gzip");
            }
        }
    }

    public record CreateContainerRegistryAuthentication(
        [property: JsonPropertyName("basic")]
            CreateContainerRegistryAuthentication.RegistryAuthenticationBasic1? Basic = null,
        [property: JsonPropertyName("gcp_gcr")]
            CreateContainerRegistryAuthentication.RegistryAuthenticationGcpGcr1? GcpGcr = null,
        [property: JsonPropertyName("aws_ecr")]
            CreateContainerRegistryAuthentication.RegistryAuthenticationAwsEcr1? AwsEcr = null,
        [property: JsonPropertyName("docker_hub")]
            CreateContainerRegistryAuthentication.RegistryAuthenticationDockerHub1? DockerHub =
            null,
        [property: JsonPropertyName("gcp_gar")]
            CreateContainerRegistryAuthentication.RegistryAuthenticationGcpGar1? GcpGar = null
    )
    {
        public record RegistryAuthenticationBasic1(
            [property: JsonPropertyName("username")] string Username,
            [property: JsonPropertyName("password")] string Password
        );

        public record RegistryAuthenticationGcpGcr1(
            [property: JsonPropertyName("service_key")] string ServiceKey
        );

        public record RegistryAuthenticationAwsEcr1(
            [property: JsonPropertyName("access_key_id")] string AccessKeyId,
            [property: JsonPropertyName("secret_access_key")] string SecretAccessKey
        );

        public record RegistryAuthenticationDockerHub1(
            [property: JsonPropertyName("username")] string Username,
            [property: JsonPropertyName("personal_access_token")] string PersonalAccessToken
        );

        public record RegistryAuthenticationGcpGar1(
            [property: JsonPropertyName("service_key")] string ServiceKey
        );
    }
}
