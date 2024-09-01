using System.Net.Http.Headers;
using System.Net.Http.Json;
using SaladCloudSdk.Http;
using SaladCloudSdk.Http.Serialization;
using SaladCloudSdk.Models;

namespace SaladCloudSdk.Services;

public class QueuesService : BaseService
{
    internal QueuesService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets the list of queues</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
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
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<QueueList>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Creates a new queue</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
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
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Queue>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets a queue</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="queueName">The unique queue name</param>
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
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Queue>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Updates a queue</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="queueName">The unique queue name</param>
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
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Queue>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Deletes a queue</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="queueName">The unique queue name</param>
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
        response.EnsureSuccessStatusCode();
    }

    /// <summary>Retrieves a list of queue jobs</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="queueName">The unique queue name</param>
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
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<QueueJobList>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Creates a new job</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="queueName">The unique queue name</param>
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
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<QueueJob>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Retrieves a job in a queue</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="queueName">The unique queue name</param>
    /// <param name="queueJobId">The unique job id</param>
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
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<QueueJob>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Deletes a queue job</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="queueName">The unique queue name</param>
    /// <param name="queueJobId">The unique job id</param>
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
        response.EnsureSuccessStatusCode();
    }
}
