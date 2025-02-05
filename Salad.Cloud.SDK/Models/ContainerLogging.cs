using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record ContainerLogging(
    [property: JsonPropertyName("axiom")] LoggingAxiom1? Axiom = null,
    [property: JsonPropertyName("datadog")] LoggingDatadog1? Datadog = null,
    [property: JsonPropertyName("new_relic")] LoggingNewRelic1? NewRelic = null,
    [property: JsonPropertyName("splunk")] LoggingSplunk1? Splunk = null,
    [property: JsonPropertyName("tcp")] LoggingTcp1? Tcp = null,
    [property: JsonPropertyName("http")] LoggingHttp1? Http = null
);
