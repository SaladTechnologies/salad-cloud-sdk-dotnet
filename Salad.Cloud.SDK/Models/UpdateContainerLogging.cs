using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

public record UpdateContainerLogging(
    [property: JsonPropertyName("axiom")] LoggingAxiom3? Axiom = null,
    [property: JsonPropertyName("datadog")] LoggingDatadog3? Datadog = null,
    [property: JsonPropertyName("new_relic")] LoggingNewRelic3? NewRelic = null,
    [property: JsonPropertyName("splunk")] LoggingSplunk3? Splunk = null,
    [property: JsonPropertyName("tcp")] LoggingTcp3? Tcp = null,
    [property: JsonPropertyName("http")] LoggingHttp3? Http = null
);
