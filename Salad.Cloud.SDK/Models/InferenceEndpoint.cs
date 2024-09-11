using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents an inference endpoint</summary>
public record InferenceEndpoint(
    /// <value>The unique identifier</value>
    [property: JsonPropertyName("id")]
        string Id,
    /// <value>The inference endpoint name</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>The inference endpoint display name</value>
    [property: JsonPropertyName("display_name")]
        string DisplayName,
    /// <value>a brief description of the inference endpoint</value>
    [property: JsonPropertyName("description")]
        string Description,
    /// <value>The URL of the inference endpoint</value>
    [property: JsonPropertyName("endpoint_url")]
        string EndpointUrl,
    /// <value>A markdown file containing a detailed description of the inference endpoint</value>
    [property: JsonPropertyName("readme")]
        string Readme,
    /// <value>A description of the price</value>
    [property: JsonPropertyName("price_description")]
        string PriceDescription,
    /// <value>The URL of the icon image</value>
    [property: JsonPropertyName("icon_image")]
        string IconImage
);
