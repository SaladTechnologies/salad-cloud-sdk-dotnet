using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record CreateContainerLogging(
    [property: JsonPropertyName("axiom")] LoggingAxiom2? Axiom = null,
    [property: JsonPropertyName("datadog")] LoggingDatadog2? Datadog = null,
    [property: JsonPropertyName("new_relic")] LoggingNewRelic2? NewRelic = null,
    [property: JsonPropertyName("splunk")] LoggingSplunk2? Splunk = null,
    [property: JsonPropertyName("tcp")] LoggingTcp2? Tcp = null,
    [property: JsonPropertyName("http")] LoggingHttp2? Http = null
);
