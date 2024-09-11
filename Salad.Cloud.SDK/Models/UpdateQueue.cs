using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a request to update an existing queue.</summary>
public record UpdateQueue(
    /// <value>The display name. This may be used as a more human-readable name.</value>
    [property: JsonPropertyName("display_name")]
        string? DisplayName = null,
    /// <value>The description. This may be used as a space for notes or other information about the queue.</value>
    [property: JsonPropertyName("description")]
        string? Description = null
);
