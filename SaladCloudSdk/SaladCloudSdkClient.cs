using SaladCloudSdk.Config;
using SaladCloudSdk.Http.Handlers;
using SaladCloudSdk.Services;
using Environment = SaladCloudSdk.Http.Environment;

namespace SaladCloudSdk;

public class SaladCloudSdkClient : IDisposable
{
    private readonly HttpClient _httpClient;
    private readonly TokenHandler _apiKeyHandler;

    public ContainerGroupsService ContainerGroups { get; private set; }
    public WorkloadErrorsService WorkloadErrors { get; private set; }
    public QueuesService Queues { get; private set; }
    public QuotasService Quotas { get; private set; }
    public InferenceEndpointsService InferenceEndpoints { get; private set; }
    public OrganizationDataService OrganizationData { get; private set; }
    public WebhookSecretKeyService WebhookSecretKey { get; private set; }

    public SaladCloudSdkClient(SaladCloudSdkConfig? config = null)
    {
        var retryHandler = new RetryHandler();
        _apiKeyHandler = new TokenHandler(retryHandler)
        {
            Header = config?.ApiKeyAuth?.ApiKeyHeader ?? ApiKeyAuthConfig.DefaultApiKeyHeader,
            Prefix = "",
            Token = config?.ApiKeyAuth?.ApiKey
        };

        _httpClient = new HttpClient(_apiKeyHandler)
        {
            BaseAddress = config?.Environment?.Uri ?? Environment.Default.Uri,
            DefaultRequestHeaders = { { "user-agent", "dotnet/7.0" } }
        };

        ContainerGroups = new ContainerGroupsService(_httpClient);
        WorkloadErrors = new WorkloadErrorsService(_httpClient);
        Queues = new QueuesService(_httpClient);
        Quotas = new QuotasService(_httpClient);
        InferenceEndpoints = new InferenceEndpointsService(_httpClient);
        OrganizationData = new OrganizationDataService(_httpClient);
        WebhookSecretKey = new WebhookSecretKeyService(_httpClient);
    }

    /// <summary>
    /// Set the environment for the entire SDK.
    /// </summary>
    public void SetEnvironment(Environment environment)
    {
        SetBaseUrl(environment.Uri);
    }

    /// <summary>
    /// Sets the base URL for entire SDK.
    /// </summary>
    public void SetBaseUrl(string baseUrl)
    {
        SetBaseUrl(new Uri(baseUrl));
    }

    /// <summary>
    /// Sets the base URL for the entire SDK.
    /// </summary>
    public void SetBaseUrl(Uri uri)
    {
        _httpClient.BaseAddress = uri;
    }

    /// <summary>
    /// Sets the API key for the entire SDK.
    /// </summary>
    public void SetApiKey(string apiKey)
    {
        _apiKeyHandler.Token = apiKey;
    }

    /// <summary>
    /// Sets the API key header for the entire SDK.
    /// </summary>
    public void SetApiKeyHeader(string apiKeyHeader)
    {
        _apiKeyHandler.Header = apiKeyHeader;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}

// c029837e0e474b76bc487506e8799df5e3335891efe4fb02bda7a1441840310c
