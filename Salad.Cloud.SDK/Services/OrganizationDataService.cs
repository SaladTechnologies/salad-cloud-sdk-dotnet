using System.Net.Http.Json;
using Salad.Cloud.SDK.Http;
using Salad.Cloud.SDK.Http.Exceptions;
using Salad.Cloud.SDK.Http.Extensions;
using Salad.Cloud.SDK.Http.Serialization;
using Salad.Cloud.SDK.Models;
using Salad.Cloud.SDK.Validation;
using Salad.Cloud.SDK.Validation.Extensions;

namespace Salad.Cloud.SDK.Services;

public class OrganizationDataService : BaseService
{
    internal OrganizationDataService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>List the GPU Classes</summary>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    public async Task<GpuClassesList> ListGpuClassesAsync(
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
            .ValidateRequired<string?>((string?)organizationName);
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
            "organizations/{organization_name}/gpu-classes"
        )
            .SetPathParameter("organization_name", organizationName)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        // Standard deserialization
        var result =
            await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<GpuClassesList>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");

        return result;
    }

    /// <summary>Gets the CPU availability for the given organization</summary>
    /// <param name="input">Represents a request to check CPU availability</param>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    public async Task<CpuAvailability> GetCpuAvailabilityAsync(
        CpuAvailabilityPrototype input,
        string organizationName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
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
        var validator = new CpuAvailabilityPrototypeValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(
            HttpMethod.Post,
            "organizations/{organization_name}/availability/sce-cpu-availability"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        // Standard deserialization
        var result =
            await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<CpuAvailability>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");

        return result;
    }

    /// <summary>Gets the GPU availability for the given organization</summary>
    /// <param name="input">Represents a request to check GPU availability</param>
    /// <param name="organizationName">Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization.</param>
    public async Task<GpuAvailability> GetGpuAvailabilityAsync(
        GpuAvailabilityPrototype input,
        string organizationName,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
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
        var validator = new GpuAvailabilityPrototypeValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(
            HttpMethod.Post,
            "organizations/{organization_name}/availability/sce-gpu-availability"
        )
            .SetPathParameter("organization_name", organizationName)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        // Standard deserialization
        var result =
            await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<GpuAvailability>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");

        return result;
    }
}
