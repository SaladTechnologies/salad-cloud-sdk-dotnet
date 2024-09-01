using System.Net.Http.Json;
using SaladCloudSdk.Http;
using SaladCloudSdk.Http.Serialization;
using SaladCloudSdk.Models;

namespace SaladCloudSdk.Services;

public class WorkloadErrorsService : BaseService
{
    internal WorkloadErrorsService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets the workload errors</summary>
    /// <param name="organizationName">The unique organization name</param>
    /// <param name="projectName">The unique project name</param>
    /// <param name="containerGroupName">The unique container group name</param>
    public async Task<WorkloadErrorList> GetWorkloadErrorsAsync(
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
            "organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/errors"
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
                .Content.ReadFromJsonAsync<WorkloadErrorList>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
