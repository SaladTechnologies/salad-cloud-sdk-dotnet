using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record CpuAvailabilityPrototype(
    /// <value>A list of country codes where the resources are available</value>
    [property:
        JsonPropertyName("country_codes"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<CountryCode>? CountryCodes = null,
    /// <value>The number of available CPU cores</value>
    [property: JsonPropertyName("cpu")]
        long? Cpu = null,
    /// <value>The amount of available memory in MB</value>
    [property: JsonPropertyName("memory")]
        long? Memory = null,
    /// <value>The amount of available storage in bytes</value>
    [property: JsonPropertyName("storage_amount")]
        long? StorageAmount = null
);
