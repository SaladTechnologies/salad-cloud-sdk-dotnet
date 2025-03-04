using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents an inference endpoint</summary>
public record InferenceEndpoint(
    /// <value>The inference endpoint identifier.</value>
    [property: JsonPropertyName("id")]
        string Id,
    /// <value>The inference endpoint name.</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>The organization name.</value>
    [property: JsonPropertyName("organization_name")]
        string OrganizationName,
    /// <value>The display-friendly name of the resource.</value>
    [property: JsonPropertyName("display_name")]
        string DisplayName,
    /// <value>The detailed description of the resource.</value>
    [property: JsonPropertyName("description")]
        string Description,
    /// <value>A markdown file containing a detailed description of the inference endpoint</value>
    [property: JsonPropertyName("readme")]
        string Readme,
    /// <value>A description of the price</value>
    [property: JsonPropertyName("price_description")]
        string PriceDescription,
    /// <value>The URL of the icon image</value>
    [property: JsonPropertyName("icon_url")]
        string IconUrl,
    /// <value>The input schema</value>
    [property: JsonPropertyName("input_schema")]
        string InputSchema,
    /// <value>The output schema</value>
    [property: JsonPropertyName("output_schema")]
        string OutputSchema
);
