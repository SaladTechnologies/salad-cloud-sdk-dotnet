using System.Net.Http.Json;
using Salad.Cloud.SDK.Http;
using Salad.Cloud.SDK.Http.Exceptions;
using Salad.Cloud.SDK.Http.Extensions;
using Salad.Cloud.SDK.Http.Serialization;
using Salad.Cloud.SDK.Models;
using Salad.Cloud.SDK.Validation;
using Salad.Cloud.SDK.Validation.Extensions;

namespace Salad.Cloud.SDK.Services;

public class InferenceEndpointsService : BaseService
{
    internal InferenceEndpointsService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets the list of inference endpoints</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="page">The page number</param>
    /// <param name="pageSize">The number of items per page</param>
    public async Task<InferenceEndpointsList> ListInferenceEndpointsAsync(
        string organizationName,
        long? page = null,
        long? pageSize = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var organizationNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .WithMatch(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .ValidateRequired<string?>((string?)organizationName);
        if (organizationNameValidationResult != null)
        {
            validationResults.Add(organizationNameValidationResult);
        }
        ;
        var pageValidationResult = new NumberValidator()
            .WithLessThanOrEqualTo(2147483647)
            .WithGreaterThanOrEqualTo(1)
            .ValidateOptional<long?>((long?)page);
        if (pageValidationResult != null)
        {
            validationResults.Add(pageValidationResult);
        }
        ;
        var pageSizeValidationResult = new NumberValidator()
            .WithLessThanOrEqualTo(100)
            .WithGreaterThanOrEqualTo(1)
            .ValidateOptional<long?>((long?)pageSize);
        if (pageSizeValidationResult != null)
        {
            validationResults.Add(pageSizeValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/inference-endpoints"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetQueryParameter("page", page)
            .SetQueryParameter("page_size", pageSize)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<InferenceEndpointsList>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets an inference endpoint</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="inferenceEndpointName">The unique inference endpoint name</param>
    public async Task<InferenceEndpoint> GetInferenceEndpointAsync(
        string organizationName,
        string inferenceEndpointName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(inferenceEndpointName, nameof(inferenceEndpointName));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var organizationNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .WithMatch(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .ValidateRequired<string?>((string?)organizationName);
        if (organizationNameValidationResult != null)
        {
            validationResults.Add(organizationNameValidationResult);
        }
        ;
        var inferenceEndpointNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .ValidateRequired<string?>((string?)inferenceEndpointName);
        if (inferenceEndpointNameValidationResult != null)
        {
            validationResults.Add(inferenceEndpointNameValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("inference_endpoint_name", inferenceEndpointName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<InferenceEndpoint>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Retrieves a list of an inference endpoint jobs</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="inferenceEndpointName">The unique inference endpoint name</param>
    /// <param name="page">The page number</param>
    /// <param name="pageSize">The number of items per page</param>
    public async Task<InferenceEndpointJobList> GetInferenceEndpointJobsAsync(
        string organizationName,
        string inferenceEndpointName,
        long? page = null,
        long? pageSize = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(inferenceEndpointName, nameof(inferenceEndpointName));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var organizationNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .WithMatch(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .ValidateRequired<string?>((string?)organizationName);
        if (organizationNameValidationResult != null)
        {
            validationResults.Add(organizationNameValidationResult);
        }
        ;
        var inferenceEndpointNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .ValidateRequired<string?>((string?)inferenceEndpointName);
        if (inferenceEndpointNameValidationResult != null)
        {
            validationResults.Add(inferenceEndpointNameValidationResult);
        }
        ;
        var pageValidationResult = new NumberValidator()
            .WithLessThanOrEqualTo(2147483647)
            .WithGreaterThanOrEqualTo(1)
            .ValidateOptional<long?>((long?)page);
        if (pageValidationResult != null)
        {
            validationResults.Add(pageValidationResult);
        }
        ;
        var pageSizeValidationResult = new NumberValidator()
            .WithLessThanOrEqualTo(100)
            .WithGreaterThanOrEqualTo(1)
            .ValidateOptional<long?>((long?)pageSize);
        if (pageSizeValidationResult != null)
        {
            validationResults.Add(pageSizeValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("inference_endpoint_name", inferenceEndpointName)
            .SetQueryParameter("page", page)
            .SetQueryParameter("page_size", pageSize)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<InferenceEndpointJobList>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Creates a new job</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="inferenceEndpointName">The unique inference endpoint name</param>
    public async Task<InferenceEndpointJob> CreateInferenceEndpointJobAsync(
        CreateInferenceEndpointJob input,
        string organizationName,
        string inferenceEndpointName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(inferenceEndpointName, nameof(inferenceEndpointName));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var organizationNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .WithMatch(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .ValidateRequired<string?>((string?)organizationName);
        if (organizationNameValidationResult != null)
        {
            validationResults.Add(organizationNameValidationResult);
        }
        ;
        var inferenceEndpointNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .ValidateRequired<string?>((string?)inferenceEndpointName);
        if (inferenceEndpointNameValidationResult != null)
        {
            validationResults.Add(inferenceEndpointNameValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(
            HttpMethod.Post,
            "organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("inference_endpoint_name", inferenceEndpointName)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<InferenceEndpointJob>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Retrieves a job in an inference endpoint</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="inferenceEndpointName">The unique inference endpoint name</param>
    /// <param name="inferenceEndpointJobId">The unique job id</param>
    public async Task<InferenceEndpointJob> GetInferenceEndpointJobAsync(
        string organizationName,
        string inferenceEndpointName,
        string inferenceEndpointJobId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(inferenceEndpointName, nameof(inferenceEndpointName));
        ArgumentNullException.ThrowIfNull(inferenceEndpointJobId, nameof(inferenceEndpointJobId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var organizationNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .WithMatch(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .ValidateRequired<string?>((string?)organizationName);
        if (organizationNameValidationResult != null)
        {
            validationResults.Add(organizationNameValidationResult);
        }
        ;
        var inferenceEndpointNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .ValidateRequired<string?>((string?)inferenceEndpointName);
        if (inferenceEndpointNameValidationResult != null)
        {
            validationResults.Add(inferenceEndpointNameValidationResult);
        }
        ;
        var inferenceEndpointJobIdValidationResult =
            new StringValidator().ValidateRequired<string?>((string?)inferenceEndpointJobId);
        if (inferenceEndpointJobIdValidationResult != null)
        {
            validationResults.Add(inferenceEndpointJobIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs/{inference_endpoint_job_id}"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("inference_endpoint_name", inferenceEndpointName)
            .SetPathParameter("inference_endpoint_job_id", inferenceEndpointJobId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<InferenceEndpointJob>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Deletes an inference endpoint job</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="inferenceEndpointName">The unique inference endpoint name</param>
    /// <param name="inferenceEndpointJobId">The unique job id</param>
    public async Task DeleteInferenceEndpointJobAsync(
        string organizationName,
        string inferenceEndpointName,
        string inferenceEndpointJobId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(inferenceEndpointName, nameof(inferenceEndpointName));
        ArgumentNullException.ThrowIfNull(inferenceEndpointJobId, nameof(inferenceEndpointJobId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var organizationNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .WithMatch(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .ValidateRequired<string?>((string?)organizationName);
        if (organizationNameValidationResult != null)
        {
            validationResults.Add(organizationNameValidationResult);
        }
        ;
        var inferenceEndpointNameValidationResult = new StringValidator()
            .WithMaximumLength(63)
            .WithMinimumLength(2)
            .ValidateRequired<string?>((string?)inferenceEndpointName);
        if (inferenceEndpointNameValidationResult != null)
        {
            validationResults.Add(inferenceEndpointNameValidationResult);
        }
        ;
        var inferenceEndpointJobIdValidationResult =
            new StringValidator().ValidateRequired<string?>((string?)inferenceEndpointJobId);
        if (inferenceEndpointJobIdValidationResult != null)
        {
            validationResults.Add(inferenceEndpointJobIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs/{inference_endpoint_job_id}"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("inference_endpoint_name", inferenceEndpointName)
            .SetPathParameter("inference_endpoint_job_id", inferenceEndpointJobId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessfulResponse();
    }
}
