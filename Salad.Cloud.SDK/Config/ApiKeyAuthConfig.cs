namespace Salad.Cloud.SDK.Config;

/// <summary>
/// Configuration for API Key authentication.
/// Stores the API key and the header name to use for authentication requests.
/// </summary>
/// <param name="ApiKey">The API key value to authenticate with.</param>
/// <param name="ApiKeyHeader">The HTTP header name to send the API key in. Defaults to the API's standard header.</param>
public record ApiKeyAuthConfig(
    string ApiKey,
    string? ApiKeyHeader = ApiKeyAuthConfig.DefaultApiKeyHeader
)
{
    /// <summary>
    /// The default HTTP header name for API key authentication as specified by the API.
    /// </summary>
    public const string DefaultApiKeyHeader = "Salad-Api-Key";
}
