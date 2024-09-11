using Environment = Salad.Cloud.SDK.Http.Environment;

namespace Salad.Cloud.SDK.Config;

/// <summary>
/// Configuration options for the SaladCloudSdkClient.
/// </summary>
public record SaladCloudSdkConfig(
    /// <value>The environment to use for the SDK.</value>
    Environment? Environment = null,
    /// <value>The api-key authentication configuration.</value>
    ApiKeyAuthConfig? ApiKeyAuth = null
);
