namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class CpuAvailabilityValidator : AbstractValidator<CpuAvailability?>
{
    public CpuAvailabilityValidator() { }
}
