using System.Net.Http.Json;
using SaladCloudSdk.Http;
using SaladCloudSdk.Http.Serialization;
using SaladCloudSdk.Models;

namespace SaladCloudSdk.Services;

public class InferenceEndpointsService : BaseService
{
    internal InferenceEndpointsService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets the list of all inference endpoints</summary>
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
        response.EnsureSuccessStatusCode();

        return await response
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
        response.EnsureSuccessStatusCode();

        return await response
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
        response.EnsureSuccessStatusCode();

        return await response
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
        response.EnsureSuccessStatusCode();

        return await response
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
        response.EnsureSuccessStatusCode();

        return await response
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
        response.EnsureSuccessStatusCode();
    }
}
