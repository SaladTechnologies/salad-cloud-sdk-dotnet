namespace SaladCloudSdk.Config;

public record ApiKeyAuthConfig(
    string ApiKey,
    string? ApiKeyHeader = ApiKeyAuthConfig.DefaultApiKeyHeader
)
{
    public const string DefaultApiKeyHeader = "Salad-Api-Key";
}
