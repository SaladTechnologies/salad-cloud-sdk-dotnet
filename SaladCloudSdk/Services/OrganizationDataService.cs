using System.Net.Http.Json;
using SaladCloudSdk.Http;
using SaladCloudSdk.Http.Serialization;
using SaladCloudSdk.Models;

namespace SaladCloudSdk.Services;

public class OrganizationDataService : BaseService
{
    internal OrganizationDataService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>List the GPU Classes</summary>
    /// <param name="organizationName">The unique organization name</param>
    public async Task<GpuClassesList> ListGpuClassesAsync(
        string organizationName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(organizationName, nameof(organizationName));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "organizations/{organization_name}/gpu-classes"
        )
            .SetPathParameter("organization_name", organizationName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GpuClassesList>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
