using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a container</summary>
public record Container(
    [property: JsonPropertyName("image")] string Image,
    /// <value>Represents a container resource requirements</value>
    [property: JsonPropertyName("resources")]
        ContainerResourceRequirements Resources,
    [property: JsonPropertyName("command")] List<string> Command,
    [property: JsonPropertyName("priority")] ContainerGroupPriority? Priority = null,
    [property:
        JsonPropertyName("size"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Size = null,
    [property:
        JsonPropertyName("hash"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Hash = null,
    [property:
        JsonPropertyName("environment_variables"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? EnvironmentVariables = null,
    [property: JsonPropertyName("logging")] Container.ContainerLogging? Logging = null
)
{
    public record ContainerLogging(
        [property: JsonPropertyName("axiom")] ContainerLogging.LoggingAxiom1? Axiom = null,
        [property: JsonPropertyName("datadog")] ContainerLogging.LoggingDatadog1? Datadog = null,
        [property: JsonPropertyName("new_relic")]
            ContainerLogging.LoggingNewRelic1? NewRelic = null,
        [property: JsonPropertyName("splunk")] ContainerLogging.LoggingSplunk1? Splunk = null,
        [property: JsonPropertyName("tcp")] ContainerLogging.LoggingTcp1? Tcp = null,
        [property: JsonPropertyName("http")] ContainerLogging.LoggingHttp1? Http = null
    )
    {
        public record LoggingAxiom1(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("api_token")] string ApiToken,
            [property: JsonPropertyName("dataset")] string Dataset
        );

        public record LoggingDatadog1(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("api_key")] string ApiKey,
            [property: JsonPropertyName("tags")] List<LoggingDatadog1.DatadogTags1>? Tags = null
        )
        {
            public record DatadogTags1(
                [property: JsonPropertyName("name")] string Name,
                [property: JsonPropertyName("value")] string Value
            );
        }

        public record LoggingNewRelic1(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("ingestion_key")] string IngestionKey
        );

        public record LoggingSplunk1(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("token")] string Token
        );

        public record LoggingTcp1(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("port")] long Port
        );

        public record LoggingHttp1(
            [property: JsonPropertyName("host")] string Host,
            [property: JsonPropertyName("port")] long Port,
            [property: JsonPropertyName("format")] LoggingHttp1.HttpFormat1 Format,
            [property: JsonPropertyName("compression")] LoggingHttp1.HttpCompression1 Compression,
            [property: JsonPropertyName("user")] string? User = null,
            [property: JsonPropertyName("password")] string? Password = null,
            [property: JsonPropertyName("path")] string? Path = null,
            [property: JsonPropertyName("headers")] List<LoggingHttp1.HttpHeaders1>? Headers = null
        )
        {
            public record HttpFormat1 : ValueEnum<string>
            {
                internal HttpFormat1(string value)
                    : base(value) { }

                public HttpFormat1()
                    : base("json") { }

                public static HttpFormat1 Json = new("json");
                public static HttpFormat1 JsonLines = new("json_lines");
            }

            public record HttpHeaders1(
                [property: JsonPropertyName("name")] string Name,
                [property: JsonPropertyName("value")] string Value
            );

            public record HttpCompression1 : ValueEnum<string>
            {
                internal HttpCompression1(string value)
                    : base(value) { }

                public HttpCompression1()
                    : base("none") { }

                public static HttpCompression1 None = new("none");
                public static HttpCompression1 Gzip = new("gzip");
            }
        }
    }
}
