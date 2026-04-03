using System.Net.Http.Json;
using Salad.Cloud.SDK.Http;
using Salad.Cloud.SDK.Http.Exceptions;
using Salad.Cloud.SDK.Http.Extensions;
using Salad.Cloud.SDK.Http.Handlers;
using Salad.Cloud.SDK.Http.Serialization;
using Salad.Cloud.SDK.Models;
using Salad.Cloud.SDK.Validation;
using Salad.Cloud.SDK.Validation.Extensions;

namespace Salad.Cloud.SDK.Services;

/// <summary>
/// Service class providing access to API endpoints for WebhookSecretKeyService.
/// Inherits HTTP client management, JSON serialization, and streaming capabilities from the base service.
/// Each method corresponds to an API operation and handles request building, execution, and response parsing.
/// </summary>
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
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var organizationNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .WithMatch(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .ValidateRequired<string>(organizationName);
        if (organizationNameValidationResult != null)
        {
            validationResults.Add(organizationNameValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/webhook-secret-key"
        )
            .SetPathParameter("organization_name", organizationName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        // Standard deserialization
        var responseContent = response.EnsureSuccessfulResponse().Content;
        var contentLength = responseContent.Headers.ContentLength;

        WebhookSecretKey result;
        if (contentLength == null || contentLength > 0)
        {
            result =
                await responseContent
                    .ReadFromJsonAsync<WebhookSecretKey>(_jsonSerializerOptions, cancellationToken)
                    .ConfigureAwait(false)
                ?? throw new Exception("Failed to deserialize response.");
        }
        else
        {
            // Empty response body - return default instance
            result = default!;
        }

        return result;
    }

    /// <summary>Updates the webhook secret key</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    public async Task<WebhookSecretKey> UpdateWebhookSecretKeyAsync(
        string organizationName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var organizationNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .WithMatch(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .ValidateRequired<string>(organizationName);
        if (organizationNameValidationResult != null)
        {
            validationResults.Add(organizationNameValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(
            HttpMethod.Post,
            "organizations/{organization_name}/webhook-secret-key"
        )
            .SetPathParameter("organization_name", organizationName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        // Standard deserialization
        var responseContent = response.EnsureSuccessfulResponse().Content;
        var contentLength = responseContent.Headers.ContentLength;

        WebhookSecretKey result;
        if (contentLength == null || contentLength > 0)
        {
            result =
                await responseContent
                    .ReadFromJsonAsync<WebhookSecretKey>(_jsonSerializerOptions, cancellationToken)
                    .ConfigureAwait(false)
                ?? throw new Exception("Failed to deserialize response.");
        }
        else
        {
            // Empty response body - return default instance
            result = default!;
        }

        return result;
    }
}
