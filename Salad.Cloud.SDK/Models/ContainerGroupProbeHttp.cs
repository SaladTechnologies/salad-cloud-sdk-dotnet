using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record ContainerGroupProbeHttp(
    [property: JsonPropertyName("path")] string Path,
    [property: JsonPropertyName("port")] long Port,
    [property:
        JsonPropertyName("scheme"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ContainerProbeHttpScheme? Scheme = null,
    [property:
        JsonPropertyName("headers"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ContainerGroupProbeHttpHeaders2>? Headers = null
);
