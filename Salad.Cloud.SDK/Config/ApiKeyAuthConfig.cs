namespace Salad.Cloud.SDK.Config;

public record ApiKeyAuthConfig(
    string ApiKey,
    string? ApiKeyHeader = ApiKeyAuthConfig.DefaultApiKeyHeader
)
{
    public const string DefaultApiKeyHeader = "Salad-Api-Key";
}
