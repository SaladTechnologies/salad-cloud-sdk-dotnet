using System.Net.Http.Json;
using Salad.Cloud.SDK.Http;
using Salad.Cloud.SDK.Http.Exceptions;
using Salad.Cloud.SDK.Http.Extensions;
using Salad.Cloud.SDK.Http.Serialization;
using Salad.Cloud.SDK.Models;

namespace Salad.Cloud.SDK.Services;

public class WebhookSecretKeyService : BaseService
{
    internal WebhookSecretKeyService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets the webhook secret key</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
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

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<WebhookSecretKey>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Updates the webhook secret key</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
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

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<WebhookSecretKey>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
