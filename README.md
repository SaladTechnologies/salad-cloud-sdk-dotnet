# SaladCloudSdk C# SDK 0.9.0-alpha.6

Welcome to the SaladCloudSdk SDK documentation. This guide will help you get started with integrating and using the SaladCloudSdk SDK in your project.

## Versions

- API version: `0.9.0-alpha.6`
- SDK version: `0.9.0-alpha.6`

## About the API

The SaladCloud REST API. Please refer to the [SaladCloud API Documentation](https://docs.salad.com/api-reference) for more details.

## Table of Contents

- [Setup & Configuration](#setup--configuration)
  - [Supported Language Versions](#supported-language-versions)
  - [Installation](#installation)
- [Authentication](#authentication)
  - [API Key Authentication](#api-key-authentication)
- [Sample Usage](#sample-usage)
- [Services](#services)
- [Models](#models)
- [License](#license)

# Setup & Configuration

## Supported Language Versions

This SDK is compatible with the following versions: `C# >= .NET 6`

## Installation

To get started with the SDK, we recommend installing using `nuget`:

```bash
dotnet add package Salad.Cloud.SDK
```

## Authentication

### API Key Authentication

The SaladCloudSdk API uses API keys as a form of authentication. An API key is a unique identifier used to authenticate a user, developer, or a program that is calling the API.

#### Setting the API key

When you initialize the SDK, you can set the API key as follows:

```cs
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new Salad.Cloud.SDKConfig()
{
	ApiKeyAuth = new ApiKeyAuthConfig("YOUR_API_KEY")
};

var client = new SaladCloudSdkClient(config);
```

If you need to set or update the API key after initializing the SDK, you can use:

```cs
client.SetApiKey("YOUR_API_KEY")
```

# Sample Usage

Below is a comprehensive example demonstrating how to authenticate and call a simple endpoint:

```cs
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var apiKeyConfig = new ApiKeyAuthConfig("YOUR_API_KEY");

var config = new SaladCloudSdkConfig
{
  Environment = Environment.Default,
  ApiKeyAuth = apiKeyConfig
};

var client = new SaladCloudSdkClient(config);

var response = await client.Quotas.GetQuotasAsync("j5rb91fzs3spaw4grzs1ulr8elj96ymws");

Console.WriteLine(response);

```

## Services

The SDK provides various services to interact with the API.

<details>
<summary>Below is a list of all available services with links to their detailed documentation:</summary>

| Name                                                                             |
| :------------------------------------------------------------------------------- |
| [ContainerGroupsService](documentation/services/ContainerGroupsService.md)       |
| [WorkloadErrorsService](documentation/services/WorkloadErrorsService.md)         |
| [SystemLogsService](documentation/services/SystemLogsService.md)                 |
| [QueuesService](documentation/services/QueuesService.md)                         |
| [QuotasService](documentation/services/QuotasService.md)                         |
| [InferenceEndpointsService](documentation/services/InferenceEndpointsService.md) |
| [OrganizationDataService](documentation/services/OrganizationDataService.md)     |
| [WebhookSecretKeyService](documentation/services/WebhookSecretKeyService.md)     |

</details>

## Models

The SDK includes several models that represent the data structures used in API requests and responses. These models help in organizing and managing the data efficiently.

<details>
<summary>Below is a list of all available models with links to their detailed documentation:</summary>

| Name                                                                                                             | Description                                                              |
| :--------------------------------------------------------------------------------------------------------------- | :----------------------------------------------------------------------- |
| [ContainerGroupList](documentation/models/ContainerGroupList.md)                                                 | Represents a list of container groups                                    |
| [CreateContainerGroup](documentation/models/CreateContainerGroup.md)                                             | Represents a request to create a container group                         |
| [ContainerGroup](documentation/models/ContainerGroup.md)                                                         | Represents a container group                                             |
| [UpdateContainerGroup](documentation/models/UpdateContainerGroup.md)                                             | Represents a request to update a container group                         |
| [ContainerGroupInstances](documentation/models/ContainerGroupInstances.md)                                       | Represents a list of container group instances                           |
| [ContainerGroupInstance](documentation/models/ContainerGroupInstance.md)                                         | Represents the details of a single container group instance              |
| [WorkloadErrorList](documentation/models/WorkloadErrorList.md)                                                   | Represents a list of workload errors                                     |
| [SystemLogList](documentation/models/SystemLogList.md)                                                           | Represents a list of system logs                                         |
| [QueueList](documentation/models/QueueList.md)                                                                   | Represents a list of queues                                              |
| [CreateQueue](documentation/models/CreateQueue.md)                                                               | Represents a request to create a new queue.                              |
| [Queue](documentation/models/Queue.md)                                                                           | Represents a queue.                                                      |
| [UpdateQueue](documentation/models/UpdateQueue.md)                                                               | Represents a request to update an existing queue.                        |
| [QueueJobList](documentation/models/QueueJobList.md)                                                             | Represents a list of queue jobs                                          |
| [CreateQueueJob](documentation/models/CreateQueueJob.md)                                                         | Represents a request to create a queue job                               |
| [QueueJob](documentation/models/QueueJob.md)                                                                     | Represents a queue job                                                   |
| [Quotas](documentation/models/Quotas.md)                                                                         | Represents the organization quotas                                       |
| [InferenceEndpointsList](documentation/models/InferenceEndpointsList.md)                                         | Represents a list of inference endpoints                                 |
| [InferenceEndpoint](documentation/models/InferenceEndpoint.md)                                                   | Represents an inference endpoint                                         |
| [InferenceEndpointJobList](documentation/models/InferenceEndpointJobList.md)                                     | Represents a list of inference endpoint jobs                             |
| [CreateInferenceEndpointJob](documentation/models/CreateInferenceEndpointJob.md)                                 | Represents a request to create a inference endpoint job                  |
| [InferenceEndpointJob](documentation/models/InferenceEndpointJob.md)                                             | Represents a inference endpoint job                                      |
| [GpuClassesList](documentation/models/GpuClassesList.md)                                                         | Represents a list of GPU classes                                         |
| [WebhookSecretKey](documentation/models/WebhookSecretKey.md)                                                     | Represents a webhook secret key                                          |
| [Container](documentation/models/Container.md)                                                                   | Represents a container                                                   |
| [ContainerRestartPolicy](documentation/models/ContainerRestartPolicy.md)                                         |                                                                          |
| [ContainerGroupState](documentation/models/ContainerGroupState.md)                                               | Represents a container group state                                       |
| [CountryCode](documentation/models/CountryCode.md)                                                               |                                                                          |
| [ContainerGroupNetworking](documentation/models/ContainerGroupNetworking.md)                                     | Represents container group networking parameters                         |
| [ContainerGroupLivenessProbe](documentation/models/ContainerGroupLivenessProbe.md)                               | Represents the container group liveness probe                            |
| [ContainerGroupReadinessProbe](documentation/models/ContainerGroupReadinessProbe.md)                             | Represents the container group readiness probe                           |
| [ContainerGroupStartupProbe](documentation/models/ContainerGroupStartupProbe.md)                                 | Represents the container group startup probe                             |
| [ContainerGroupQueueConnection](documentation/models/ContainerGroupQueueConnection.md)                           | Represents container group queue connection                              |
| [QueueAutoscaler](documentation/models/QueueAutoscaler.md)                                                       | Represents the autoscaling rules for a queue                             |
| [ContainerResourceRequirements](documentation/models/ContainerResourceRequirements.md)                           | Represents a container resource requirements                             |
| [ContainerGroupPriority](documentation/models/ContainerGroupPriority.md)                                         |                                                                          |
| [ContainerLogging](documentation/models/ContainerLogging.md)                                                     |                                                                          |
| [LoggingAxiom1](documentation/models/LoggingAxiom1.md)                                                           |                                                                          |
| [LoggingDatadog1](documentation/models/LoggingDatadog1.md)                                                       |                                                                          |
| [LoggingNewRelic1](documentation/models/LoggingNewRelic1.md)                                                     |                                                                          |
| [LoggingSplunk1](documentation/models/LoggingSplunk1.md)                                                         |                                                                          |
| [LoggingTcp1](documentation/models/LoggingTcp1.md)                                                               |                                                                          |
| [LoggingHttp1](documentation/models/LoggingHttp1.md)                                                             |                                                                          |
| [DatadogTags1](documentation/models/DatadogTags1.md)                                                             |                                                                          |
| [HttpFormat1](documentation/models/HttpFormat1.md)                                                               |                                                                          |
| [HttpHeaders1](documentation/models/HttpHeaders1.md)                                                             |                                                                          |
| [HttpCompression1](documentation/models/HttpCompression1.md)                                                     |                                                                          |
| [ContainerGroupStatus](documentation/models/ContainerGroupStatus.md)                                             |                                                                          |
| [ContainerGroupInstanceStatusCount](documentation/models/ContainerGroupInstanceStatusCount.md)                   | Represents a container group instance status count                       |
| [ContainerNetworkingProtocol](documentation/models/ContainerNetworkingProtocol.md)                               |                                                                          |
| [ContainerGroupNetworkingLoadBalancer](documentation/models/ContainerGroupNetworkingLoadBalancer.md)             |                                                                          |
| [ContainerGroupProbeTcp](documentation/models/ContainerGroupProbeTcp.md)                                         |                                                                          |
| [ContainerGroupProbeHttp](documentation/models/ContainerGroupProbeHttp.md)                                       |                                                                          |
| [ContainerGroupProbeGrpc](documentation/models/ContainerGroupProbeGrpc.md)                                       |                                                                          |
| [ContainerGroupProbeExec](documentation/models/ContainerGroupProbeExec.md)                                       |                                                                          |
| [ContainerProbeHttpScheme](documentation/models/ContainerProbeHttpScheme.md)                                     |                                                                          |
| [ContainerGroupProbeHttpHeaders2](documentation/models/ContainerGroupProbeHttpHeaders2.md)                       |                                                                          |
| [CreateContainer](documentation/models/CreateContainer.md)                                                       | Represents a container                                                   |
| [CreateContainerGroupNetworking](documentation/models/CreateContainerGroupNetworking.md)                         | Represents container group networking parameters                         |
| [CreateContainerLogging](documentation/models/CreateContainerLogging.md)                                         |                                                                          |
| [CreateContainerRegistryAuthentication](documentation/models/CreateContainerRegistryAuthentication.md)           |                                                                          |
| [LoggingAxiom2](documentation/models/LoggingAxiom2.md)                                                           |                                                                          |
| [LoggingDatadog2](documentation/models/LoggingDatadog2.md)                                                       |                                                                          |
| [LoggingNewRelic2](documentation/models/LoggingNewRelic2.md)                                                     |                                                                          |
| [LoggingSplunk2](documentation/models/LoggingSplunk2.md)                                                         |                                                                          |
| [LoggingTcp2](documentation/models/LoggingTcp2.md)                                                               |                                                                          |
| [LoggingHttp2](documentation/models/LoggingHttp2.md)                                                             |                                                                          |
| [DatadogTags2](documentation/models/DatadogTags2.md)                                                             |                                                                          |
| [HttpFormat2](documentation/models/HttpFormat2.md)                                                               |                                                                          |
| [HttpHeaders3](documentation/models/HttpHeaders3.md)                                                             |                                                                          |
| [HttpCompression2](documentation/models/HttpCompression2.md)                                                     |                                                                          |
| [RegistryAuthenticationBasic1](documentation/models/RegistryAuthenticationBasic1.md)                             |                                                                          |
| [RegistryAuthenticationGcpGcr1](documentation/models/RegistryAuthenticationGcpGcr1.md)                           |                                                                          |
| [RegistryAuthenticationAwsEcr1](documentation/models/RegistryAuthenticationAwsEcr1.md)                           |                                                                          |
| [RegistryAuthenticationDockerHub1](documentation/models/RegistryAuthenticationDockerHub1.md)                     |                                                                          |
| [RegistryAuthenticationGcpGar1](documentation/models/RegistryAuthenticationGcpGar1.md)                           |                                                                          |
| [CreateContainerGroupNetworkingLoadBalancer](documentation/models/CreateContainerGroupNetworkingLoadBalancer.md) |                                                                          |
| [UpdateContainer](documentation/models/UpdateContainer.md)                                                       | Represents an update container object                                    |
| [UpdateContainerGroupNetworking](documentation/models/UpdateContainerGroupNetworking.md)                         | Represents update container group networking parameters                  |
| [Resources](documentation/models/Resources.md)                                                                   |                                                                          |
| [UpdateContainerLogging](documentation/models/UpdateContainerLogging.md)                                         |                                                                          |
| [UpdateContainerRegistryAuthentication](documentation/models/UpdateContainerRegistryAuthentication.md)           |                                                                          |
| [LoggingAxiom3](documentation/models/LoggingAxiom3.md)                                                           |                                                                          |
| [LoggingDatadog3](documentation/models/LoggingDatadog3.md)                                                       |                                                                          |
| [LoggingNewRelic3](documentation/models/LoggingNewRelic3.md)                                                     |                                                                          |
| [LoggingSplunk3](documentation/models/LoggingSplunk3.md)                                                         |                                                                          |
| [LoggingTcp3](documentation/models/LoggingTcp3.md)                                                               |                                                                          |
| [LoggingHttp3](documentation/models/LoggingHttp3.md)                                                             |                                                                          |
| [DatadogTags3](documentation/models/DatadogTags3.md)                                                             |                                                                          |
| [HttpFormat3](documentation/models/HttpFormat3.md)                                                               |                                                                          |
| [HttpHeaders4](documentation/models/HttpHeaders4.md)                                                             |                                                                          |
| [HttpCompression3](documentation/models/HttpCompression3.md)                                                     |                                                                          |
| [RegistryAuthenticationBasic2](documentation/models/RegistryAuthenticationBasic2.md)                             |                                                                          |
| [RegistryAuthenticationGcpGcr2](documentation/models/RegistryAuthenticationGcpGcr2.md)                           |                                                                          |
| [RegistryAuthenticationAwsEcr2](documentation/models/RegistryAuthenticationAwsEcr2.md)                           |                                                                          |
| [RegistryAuthenticationDockerHub2](documentation/models/RegistryAuthenticationDockerHub2.md)                     |                                                                          |
| [RegistryAuthenticationGcpGar2](documentation/models/RegistryAuthenticationGcpGar2.md)                           |                                                                          |
| [State](documentation/models/State.md)                                                                           | The state of the container group instance                                |
| [WorkloadError](documentation/models/WorkloadError.md)                                                           | Represents a workload error                                              |
| [SystemLog](documentation/models/SystemLog.md)                                                                   | Represents a system log                                                  |
| [QueueJobStatus](documentation/models/QueueJobStatus.md)                                                         |                                                                          |
| [QueueJobEvent](documentation/models/QueueJobEvent.md)                                                           | Represents an event for queue job                                        |
| [QueueJobEventAction](documentation/models/QueueJobEventAction.md)                                               |                                                                          |
| [ContainerGroupsQuotas](documentation/models/ContainerGroupsQuotas.md)                                           |                                                                          |
| [InferenceEndpointJobStatus](documentation/models/InferenceEndpointJobStatus.md)                                 |                                                                          |
| [InferenceEndpointJobEvent](documentation/models/InferenceEndpointJobEvent.md)                                   | Represents an event for inference endpoint job                           |
| [InferenceEndpointJobEventAction](documentation/models/InferenceEndpointJobEventAction.md)                       |                                                                          |
| [GpuClass](documentation/models/GpuClass.md)                                                                     | Represents a GPU Class                                                   |
| [GpuClassPrice](documentation/models/GpuClassPrice.md)                                                           | Represents the price of a GPU class for a given container group priority |

</details>

## License

This SDK is licensed under the MIT License.

See the [LICENSE](LICENSE) file for more details.
