using System.Net.Http.Headers;
using System.Net.Http.Json;
using Salad.Cloud.SDK.Http;
using Salad.Cloud.SDK.Http.Exceptions;
using Salad.Cloud.SDK.Http.Extensions;
using Salad.Cloud.SDK.Http.Serialization;
using Salad.Cloud.SDK.Models;

namespace Salad.Cloud.SDK.Services;

public class QueuesService : BaseService
{
    internal QueuesService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets the list of queues in the given project.</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="projectName">Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.</param>
    public async Task<QueueList> ListQueuesAsync(
        string organizationName,
        string projectName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/projects/{project_name}/queues"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<QueueList>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Creates a new queue in the given project.</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="projectName">Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.</param>
    public async Task<Queue> CreateQueueAsync(
        CreateQueue input,
        string organizationName,
        string projectName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));

        var request = new RequestBuilder(
            HttpMethod.Post,
            "organizations/{organization_name}/projects/{project_name}/queues"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<Queue>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets an existing queue in the given project.</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="projectName">Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.</param>
    /// <param name="queueName">The queue name.</param>
    public async Task<Queue> GetQueueAsync(
        string organizationName,
        string projectName,
        string queueName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(queueName, nameof(queueName));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/projects/{project_name}/queues/{queue_name}"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("queue_name", queueName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<Queue>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Updates an existing queue in the given project.</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="projectName">Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.</param>
    /// <param name="queueName">The queue name.</param>
    public async Task<Queue> UpdateQueueAsync(
        UpdateQueue input,
        string organizationName,
        string projectName,
        string queueName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(queueName, nameof(queueName));

        var request = new RequestBuilder(
            HttpMethod.Patch,
            "organizations/{organization_name}/projects/{project_name}/queues/{queue_name}"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("queue_name", queueName)
            .SetContentAsJson(
                input,
                _jsonSerializerOptions,
                MediaTypeHeaderValue.Parse("application/merge-patch+json")
            )
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<Queue>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Deletes an existing queue in the given project.</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="projectName">Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.</param>
    /// <param name="queueName">The queue name.</param>
    public async Task DeleteQueueAsync(
        string organizationName,
        string projectName,
        string queueName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(queueName, nameof(queueName));

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "organizations/{organization_name}/projects/{project_name}/queues/{queue_name}"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("queue_name", queueName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessfulResponse();
    }

    /// <summary>Retrieves a list of queue jobs</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="projectName">Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.</param>
    /// <param name="queueName">The queue name.</param>
    /// <param name="page">The page number</param>
    /// <param name="pageSize">The number of items per page</param>
    public async Task<QueueJobList> ListQueueJobsAsync(
        string organizationName,
        string projectName,
        string queueName,
        long? page = null,
        long? pageSize = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(queueName, nameof(queueName));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/projects/{project_name}/queues/{queue_name}/jobs"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("queue_name", queueName)
            .SetQueryParameter("page", page)
            .SetQueryParameter("page_size", pageSize)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<QueueJobList>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Creates a new job</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="projectName">Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.</param>
    /// <param name="queueName">The queue name.</param>
    public async Task<QueueJob> CreateQueueJobAsync(
        CreateQueueJob input,
        string organizationName,
        string projectName,
        string queueName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(queueName, nameof(queueName));

        var request = new RequestBuilder(
            HttpMethod.Post,
            "organizations/{organization_name}/projects/{project_name}/queues/{queue_name}/jobs"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("queue_name", queueName)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<QueueJob>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Retrieves a job in a queue</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="projectName">Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.</param>
    /// <param name="queueName">The queue name.</param>
    /// <param name="queueJobId">The job identifier. This is automatically generated and assigned when the job is created.</param>
    public async Task<QueueJob> GetQueueJobAsync(
        string organizationName,
        string projectName,
        string queueName,
        string queueJobId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(queueName, nameof(queueName));
        ArgumentNullException.ThrowIfNull(queueJobId, nameof(queueJobId));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/projects/{project_name}/queues/{queue_name}/jobs/{queue_job_id}"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("queue_name", queueName)
            .SetPathParameter("queue_job_id", queueJobId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<QueueJob>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Deletes a queue job</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    /// <param name="projectName">Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.</param>
    /// <param name="queueName">The queue name.</param>
    /// <param name="queueJobId">The job identifier. This is automatically generated and assigned when the job is created.</param>
    public async Task DeleteQueueJobAsync(
        string organizationName,
        string projectName,
        string queueName,
        string queueJobId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(queueName, nameof(queueName));
        ArgumentNullException.ThrowIfNull(queueJobId, nameof(queueJobId));

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "organizations/{organization_name}/projects/{project_name}/queues/{queue_name}/jobs/{queue_job_id}"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("queue_name", queueName)
            .SetPathParameter("queue_job_id", queueJobId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessfulResponse();
    }
}
