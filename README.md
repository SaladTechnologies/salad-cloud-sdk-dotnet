# SaladCloudSdk C# SDK 0.9.0-alpha.4

Welcome to the SaladCloudSdk SDK documentation. This guide will help you get started with integrating and using the SaladCloudSdk SDK in your project.

## Versions

- API version: `0.9.0-alpha.4`
- SDK version: `0.9.0-alpha.4`

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

var response = await client.Quotas.GetQuotasAsync("o110sou");

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

| Name                                                                                           | Description                                                              |
| :--------------------------------------------------------------------------------------------- | :----------------------------------------------------------------------- |
| [ContainerGroupList](documentation/models/ContainerGroupList.md)                               | Represents a list of container groups                                    |
| [CreateContainerGroup](documentation/models/CreateContainerGroup.md)                           | Represents a request to create a container group                         |
| [ContainerGroup](documentation/models/ContainerGroup.md)                                       | Represents a container group                                             |
| [UpdateContainerGroup](documentation/models/UpdateContainerGroup.md)                           | Represents a request to update a container group                         |
| [ContainerGroupInstances](documentation/models/ContainerGroupInstances.md)                     | Represents a list of container group instances                           |
| [ContainerGroupInstance](documentation/models/ContainerGroupInstance.md)                       | Represents the details of a single container group instance              |
| [WorkloadErrorList](documentation/models/WorkloadErrorList.md)                                 | Represents a list of workload errors                                     |
| [QueueList](documentation/models/QueueList.md)                                                 | Represents a list of queues                                              |
| [CreateQueue](documentation/models/CreateQueue.md)                                             | Represents a request to create a new queue.                              |
| [Queue](documentation/models/Queue.md)                                                         | Represents a queue.                                                      |
| [UpdateQueue](documentation/models/UpdateQueue.md)                                             | Represents a request to update an existing queue.                        |
| [QueueJobList](documentation/models/QueueJobList.md)                                           | Represents a list of queue jobs                                          |
| [CreateQueueJob](documentation/models/CreateQueueJob.md)                                       | Represents a request to create a queue job                               |
| [QueueJob](documentation/models/QueueJob.md)                                                   | Represents a queue job                                                   |
| [Quotas](documentation/models/Quotas.md)                                                       | Represents the organization quotas                                       |
| [InferenceEndpointsList](documentation/models/InferenceEndpointsList.md)                       | Represents a list of inference endpoints                                 |
| [InferenceEndpoint](documentation/models/InferenceEndpoint.md)                                 | Represents an inference endpoint                                         |
| [InferenceEndpointJobList](documentation/models/InferenceEndpointJobList.md)                   | Represents a list of inference endpoint jobs                             |
| [CreateInferenceEndpointJob](documentation/models/CreateInferenceEndpointJob.md)               | Represents a request to create a inference endpoint job                  |
| [InferenceEndpointJob](documentation/models/InferenceEndpointJob.md)                           | Represents a inference endpoint job                                      |
| [GpuClassesList](documentation/models/GpuClassesList.md)                                       | Represents a list of GPU classes                                         |
| [WebhookSecretKey](documentation/models/WebhookSecretKey.md)                                   | Represents a webhook secret key                                          |
| [Container](documentation/models/Container.md)                                                 | Represents a container                                                   |
| [ContainerRestartPolicy](documentation/models/ContainerRestartPolicy.md)                       |                                                                          |
| [ContainerGroupState](documentation/models/ContainerGroupState.md)                             | Represents a container group state                                       |
| [CountryCode](documentation/models/CountryCode.md)                                             |                                                                          |
| [ContainerGroupNetworking](documentation/models/ContainerGroupNetworking.md)                   | Represents container group networking parameters                         |
| [ContainerGroupLivenessProbe](documentation/models/ContainerGroupLivenessProbe.md)             | Represents the container group liveness probe                            |
| [ContainerGroupReadinessProbe](documentation/models/ContainerGroupReadinessProbe.md)           | Represents the container group readiness probe                           |
| [ContainerGroupStartupProbe](documentation/models/ContainerGroupStartupProbe.md)               | Represents the container group startup probe                             |
| [ContainerGroupQueueConnection](documentation/models/ContainerGroupQueueConnection.md)         | Represents container group queue connection                              |
| [QueueAutoscaler](documentation/models/QueueAutoscaler.md)                                     | Represents the autoscaling rules for a queue                             |
| [ContainerResourceRequirements](documentation/models/ContainerResourceRequirements.md)         | Represents a container resource requirements                             |
| [ContainerGroupPriority](documentation/models/ContainerGroupPriority.md)                       |                                                                          |
| [ContainerGroupStatus](documentation/models/ContainerGroupStatus.md)                           |                                                                          |
| [ContainerGroupInstanceStatusCount](documentation/models/ContainerGroupInstanceStatusCount.md) | Represents a container group instance status count                       |
| [ContainerNetworkingProtocol](documentation/models/ContainerNetworkingProtocol.md)             |                                                                          |
| [ContainerGroupProbeTcp](documentation/models/ContainerGroupProbeTcp.md)                       |                                                                          |
| [ContainerGroupProbeHttp](documentation/models/ContainerGroupProbeHttp.md)                     |                                                                          |
| [ContainerGroupProbeGrpc](documentation/models/ContainerGroupProbeGrpc.md)                     |                                                                          |
| [ContainerGroupProbeExec](documentation/models/ContainerGroupProbeExec.md)                     |                                                                          |
| [ContainerProbeHttpScheme](documentation/models/ContainerProbeHttpScheme.md)                   |                                                                          |
| [ContainerGroupProbeHttpHeaders2](documentation/models/ContainerGroupProbeHttpHeaders2.md)     |                                                                          |
| [CreateContainer](documentation/models/CreateContainer.md)                                     | Represents a container                                                   |
| [CreateContainerGroupNetworking](documentation/models/CreateContainerGroupNetworking.md)       | Represents container group networking parameters                         |
| [UpdateContainer](documentation/models/UpdateContainer.md)                                     | Represents an update container object                                    |
| [UpdateContainerGroupNetworking](documentation/models/UpdateContainerGroupNetworking.md)       | Represents update container group networking parameters                  |
| [WorkloadError](documentation/models/WorkloadError.md)                                         | Represents a workload error                                              |
| [QueueJobEvent](documentation/models/QueueJobEvent.md)                                         | Represents an event for queue job                                        |
| [ContainerGroupsQuotas](documentation/models/ContainerGroupsQuotas.md)                         |                                                                          |
| [InferenceEndpointJobEvent](documentation/models/InferenceEndpointJobEvent.md)                 | Represents an event for inference endpoint job                           |
| [GpuClass](documentation/models/GpuClass.md)                                                   | Represents a GPU Class                                                   |
| [GpuClassPrice](documentation/models/GpuClassPrice.md)                                         | Represents the price of a GPU class for a given container group priority |

</details>

## License

This SDK is licensed under the MIT License.

See the [LICENSE](LICENSE) file for more details.
