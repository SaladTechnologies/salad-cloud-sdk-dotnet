using System.Net.Http.Headers;
using System.Net.Http.Json;
using SaladCloudSdk.Http;
using SaladCloudSdk.Http.Serialization;
using SaladCloudSdk.Models;

namespace SaladCloudSdk.Services;

public class ContainerGroupsService : BaseService
{
    internal ContainerGroupsService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets the list of container groups</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    public async Task<ContainerGroupList> ListContainerGroupsAsync(
        string organizationName,
        string projectName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/projects/{project_name}/containers"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ContainerGroupList>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Creates a new container group</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    public async Task<ContainerGroup> CreateContainerGroupAsync(
        CreateContainerGroup input,
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
            "organizations/{organization_name}/projects/{project_name}/containers"
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
                .Content.ReadFromJsonAsync<ContainerGroup>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets a container group</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="containerGroupName">The unique container group name</param>
    public async Task<ContainerGroup> GetContainerGroupAsync(
        string organizationName,
        string projectName,
        string containerGroupName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(containerGroupName, nameof(containerGroupName));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("container_group_name", containerGroupName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ContainerGroup>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Updates a container group</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="containerGroupName">The unique container group name</param>
    public async Task<ContainerGroup> UpdateContainerGroupAsync(
        UpdateContainerGroup input,
        string organizationName,
        string projectName,
        string containerGroupName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(containerGroupName, nameof(containerGroupName));

        var request = new RequestBuilder(
            HttpMethod.Patch,
            "organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("container_group_name", containerGroupName)
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
                .Content.ReadFromJsonAsync<ContainerGroup>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Deletes a container group</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="containerGroupName">The unique container group name</param>
    public async Task DeleteContainerGroupAsync(
        string organizationName,
        string projectName,
        string containerGroupName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(containerGroupName, nameof(containerGroupName));

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("container_group_name", containerGroupName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <summary>Starts a container group</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="containerGroupName">The unique container group name</param>
    public async Task StartContainerGroupAsync(
        string organizationName,
        string projectName,
        string containerGroupName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(containerGroupName, nameof(containerGroupName));

        var request = new RequestBuilder(
            HttpMethod.Post,
            "organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/start"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("container_group_name", containerGroupName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <summary>Stops a container group</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="containerGroupName">The unique container group name</param>
    public async Task StopContainerGroupAsync(
        string organizationName,
        string projectName,
        string containerGroupName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(containerGroupName, nameof(containerGroupName));

        var request = new RequestBuilder(
            HttpMethod.Post,
            "organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/stop"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("container_group_name", containerGroupName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <summary>Retrieves a list of container group instances</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="containerGroupName">The unique container group name</param>
    public async Task<ContainerGroupInstances> ListContainerGroupInstancesAsync(
        string organizationName,
        string projectName,
        string containerGroupName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(containerGroupName, nameof(containerGroupName));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/instances"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("container_group_name", containerGroupName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ContainerGroupInstances>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Retrieves the details of a single instance within a container group by instance ID</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="containerGroupName">The unique container group name</param>
    /// <param name="containerGroupInstanceId">The unique instance identifier</param>
    public async Task<ContainerGroupInstance> GetContainerGroupInstanceAsync(
        string organizationName,
        string projectName,
        string containerGroupName,
        string containerGroupInstanceId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(containerGroupName, nameof(containerGroupName));
        ArgumentNullException.ThrowIfNull(
            containerGroupInstanceId,
            nameof(containerGroupInstanceId)
        );

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/instances/{container_group_instance_id}"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("container_group_name", containerGroupName)
            .SetPathParameter("container_group_instance_id", containerGroupInstanceId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ContainerGroupInstance>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Remove a node from a workload and reallocate the workload to a different node</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="containerGroupName">The unique container group name</param>
    /// <param name="containerGroupInstanceId">The unique instance identifier</param>
    public async Task ReallocateContainerGroupInstanceAsync(
        string organizationName,
        string projectName,
        string containerGroupName,
        string containerGroupInstanceId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(containerGroupName, nameof(containerGroupName));
        ArgumentNullException.ThrowIfNull(
            containerGroupInstanceId,
            nameof(containerGroupInstanceId)
        );

        var request = new RequestBuilder(
            HttpMethod.Post,
            "organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/instances/{container_group_instance_id}/reallocate"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("container_group_name", containerGroupName)
            .SetPathParameter("container_group_instance_id", containerGroupInstanceId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <summary>Stops a container, destroys it, creates a new one without requiring the image to be downloaded again on a different node</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="containerGroupName">The unique container group name</param>
    /// <param name="containerGroupInstanceId">The unique instance identifier</param>
    public async Task RecreateContainerGroupInstanceAsync(
        string organizationName,
        string projectName,
        string containerGroupName,
        string containerGroupInstanceId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(containerGroupName, nameof(containerGroupName));
        ArgumentNullException.ThrowIfNull(
            containerGroupInstanceId,
            nameof(containerGroupInstanceId)
        );

        var request = new RequestBuilder(
            HttpMethod.Post,
            "organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/instances/{container_group_instance_id}/recreate"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("container_group_name", containerGroupName)
            .SetPathParameter("container_group_instance_id", containerGroupInstanceId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <summary>Restarts a workload on a node without reallocating it</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="containerGroupName">The unique container group name</param>
    /// <param name="containerGroupInstanceId">The unique instance identifier</param>
    public async Task RestartContainerGroupInstanceAsync(
        string organizationName,
        string projectName,
        string containerGroupName,
        string containerGroupInstanceId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));
        ArgumentNullException.ThrowIfNull(projectName, nameof(projectName));
        ArgumentNullException.ThrowIfNull(containerGroupName, nameof(containerGroupName));
        ArgumentNullException.ThrowIfNull(
            containerGroupInstanceId,
            nameof(containerGroupInstanceId)
        );

        var request = new RequestBuilder(
            HttpMethod.Post,
            "organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/instances/{container_group_instance_id}/restart"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetPathParameter("project_name", projectName)
            .SetPathParameter("container_group_name", containerGroupName)
            .SetPathParameter("container_group_instance_id", containerGroupInstanceId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }
}
