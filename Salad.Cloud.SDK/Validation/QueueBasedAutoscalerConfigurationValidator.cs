namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class QueueBasedAutoscalerConfigurationValidator
    : AbstractValidator<QueueBasedAutoscalerConfiguration?>
{
    public QueueBasedAutoscalerConfigurationValidator()
    {
        RuleFor(QueueBasedAutoscalerConfiguration =>
                QueueBasedAutoscalerConfiguration.DesiredQueueLength
            )
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for desired_queue_length is 1.")
            .LessThanOrEqualTo(100)
            .WithMessage("Minimum for desired_queue_length is 100.")
            .NotNull()
            .WithMessage("Field desired_queue_length is required.");
        RuleFor(QueueBasedAutoscalerConfiguration => QueueBasedAutoscalerConfiguration.MaxReplicas)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for max_replicas is 1.")
            .LessThanOrEqualTo(500)
            .WithMessage("Minimum for max_replicas is 500.")
            .NotNull()
            .WithMessage("Field max_replicas is required.");
        RuleFor(QueueBasedAutoscalerConfiguration => QueueBasedAutoscalerConfiguration.MinReplicas)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for min_replicas is 0.")
            .LessThanOrEqualTo(100)
            .WithMessage("Minimum for min_replicas is 100.")
            .NotNull()
            .WithMessage("Field min_replicas is required.");
        RuleFor(QueueBasedAutoscalerConfiguration =>
                QueueBasedAutoscalerConfiguration.MaxDownscalePerMinute
            )
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for max_downscale_per_minute is 1.")
            .LessThanOrEqualTo(100)
            .WithMessage("Minimum for max_downscale_per_minute is 100.");
        RuleFor(QueueBasedAutoscalerConfiguration =>
                QueueBasedAutoscalerConfiguration.MaxUpscalePerMinute
            )
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for max_upscale_per_minute is 1.")
            .LessThanOrEqualTo(100)
            .WithMessage("Minimum for max_upscale_per_minute is 100.");
        RuleFor(QueueBasedAutoscalerConfiguration =>
                QueueBasedAutoscalerConfiguration.PollingPeriod
            )
            .GreaterThanOrEqualTo(15)
            .WithMessage("Minimum for polling_period is 15.")
            .LessThanOrEqualTo(1800)
            .WithMessage("Minimum for polling_period is 1800.");
    }
}
