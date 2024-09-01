using System.Net.Http.Json;
using SaladCloudSdk.Http;
using SaladCloudSdk.Http.Serialization;
using SaladCloudSdk.Models;

namespace SaladCloudSdk.Services;

public class WebhookSecretKeyService : BaseService
{
    internal WebhookSecretKeyService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets the webhook secret key</summary>
    /// <param name="organizationName">The unique organization name</param>
    public async Task<WebhookSecretKey> GetWebhookSecretKeyAsync(
        string organizationName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/webhook-secret-key"
        )
            .SetPathParameter("organization_name", organizationName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<WebhookSecretKey>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Updates the webhook secret key</summary>
    /// <param name="organizationName">The unique organization name</param>
    public async Task<WebhookSecretKey> UpdateWebhookSecretKeyAsync(
        string organizationName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));

        var request = new RequestBuilder(
            HttpMethod.Post,
            "organizations/{organization_name}/webhook-secret-key"
        )
            .SetPathParameter("organization_name", organizationName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<WebhookSecretKey>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
