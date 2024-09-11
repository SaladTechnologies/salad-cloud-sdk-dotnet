using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a webhook secret key</summary>
public record WebhookSecretKey(
    /// <value>The webhook secret key</value>
    [property: JsonPropertyName("secret_key")]
        string SecretKey
);
