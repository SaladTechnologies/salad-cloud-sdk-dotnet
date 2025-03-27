# ContainerGroupsService

A list of all methods in the `ContainerGroupsService` service. Click on the method name to view detailed information about that method.

| Methods                                                                         | Description                                                                                                                 |
| :------------------------------------------------------------------------------ | :-------------------------------------------------------------------------------------------------------------------------- |
| [ListContainerGroupsAsync](#listcontainergroupsasync)                           | Gets the list of container groups                                                                                           |
| [CreateContainerGroupAsync](#createcontainergroupasync)                         | Creates a new container group                                                                                               |
| [GetContainerGroupAsync](#getcontainergroupasync)                               | Gets a container group                                                                                                      |
| [UpdateContainerGroupAsync](#updatecontainergroupasync)                         | Updates a container group                                                                                                   |
| [DeleteContainerGroupAsync](#deletecontainergroupasync)                         | Deletes a container group                                                                                                   |
| [StartContainerGroupAsync](#startcontainergroupasync)                           | Starts a container group                                                                                                    |
| [StopContainerGroupAsync](#stopcontainergroupasync)                             | Stops a container group                                                                                                     |
| [ListContainerGroupInstancesAsync](#listcontainergroupinstancesasync)           | Gets the list of container group instances                                                                                  |
| [GetContainerGroupInstanceAsync](#getcontainergroupinstanceasync)               | Gets a container group instance                                                                                             |
| [UpdateContainerGroupInstanceAsync](#updatecontainergroupinstanceasync)         | Updates a container group instance                                                                                          |
| [ReallocateContainerGroupInstanceAsync](#reallocatecontainergroupinstanceasync) | Reallocates a container group instance to run on a different Salad Node                                                     |
| [RecreateContainerGroupInstanceAsync](#recreatecontainergroupinstanceasync)     | Stops a container, destroys it, and starts a new one without requiring the image to be downloaded again on a new Salad Node |
| [RestartContainerGroupInstanceAsync](#restartcontainergroupinstanceasync)       | Stops a container and restarts it on the same Salad Node                                                                    |

## ListContainerGroupsAsync

Gets the list of container groups

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers`

**Parameters**

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName      | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |

**Return Type**

`ContainerGroupCollection`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.ContainerGroups.ListContainerGroupsAsync("acme-corp", "dev-env");

Console.WriteLine(response);
```

## CreateContainerGroupAsync

Creates a new container group

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers`

**Parameters**

| Name             | Type                          | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :---------------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input            | ContainerGroupCreationRequest | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName | string                        | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName      | string                        | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |

**Return Type**

`ContainerGroup`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var gpuClasses = new List<string>() { "gpu_classes" };
var resources = new ContainerResourceRequirements(4, 57453, gpuClasses, 28987146013);
var command = new List<string>() { "command" };
var axiom = new AxiomLoggingConfiguration("host", "api_token", "dataset");
var tagsItem = new DatadogTagForContainerLogging("name", "value");
var tags = new List<DatadogTagForContainerLogging>() { tagsItem };
var datadog = new DatadogLoggingConfiguration("host", "api_key", tags);
var headersItem = new ContainerLoggingHttpHeader("name", "value");
var headers = new List<ContainerLoggingHttpHeader>() { headersItem };
var http = new ContainerLoggingConfigurationHttp2("host", 22892, ContainerLoggingHttpFormat.Json, ContainerLoggingHttpCompression.None, "user", "password", "path", headers);
var newRelic = new NewRelicLoggingConfiguration("host", "ingestion_key");
var splunk = new ContainerLoggingSplunkConfiguration("host", "token");
var tcp = new TcpLoggingConfiguration("host", 35279);
var logging = new ContainerConfigurationLogging(axiom, datadog, http, newRelic, splunk, tcp);
var awsEcr = new ContainerRegistryAuthenticationAwsEcr("access_key_id", "secret_access_key");
var basic = new ContainerRegistryAuthenticationBasic("username", "password");
var dockerHub = new ContainerRegistryAuthenticationDockerHub("username", "personal_access_token");
var gcpGar = new ContainerRegistryAuthenticationGcpGar("service_key");
var gcpGcr = new ContainerRegistryAuthenticationGcpGcr("service_key");
var registryAuthentication = new ContainerRegistryAuthentication(awsEcr, basic, dockerHub, gcpGar, gcpGcr);
var container = new ContainerConfiguration("acme/:latest", resources, command, new object(), true, logging, ContainerGroupPriority.High, registryAuthentication);
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(7022, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 60740, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(42000);
var livenessProbe = new ContainerGroupLivenessProbe(3, 208, 10, 1, 30, exec, grpc, http, tcp);
var networking = new CreateContainerGroupNetworking(true, 60000, ContainerNetworkingProtocol.Http, 100000, TheContainerGroupNetworkingLoadBalancer.RoundRobin, 100000, false);
var queueAutoscaler = new QueueBasedAutoscalerConfiguration(65, 288, 21, 45, 56, 1604);
var queueConnection = new ContainerGroupQueueConnection("path", 23705, "xvx-tc09f1h-3z01x-i8ye07harfhdjmgk");
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(7022, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 60740, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(42000);
var readinessProbe = new ContainerGroupReadinessProbe(3, 137, 1, 1, 1, exec, grpc, http, tcp);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(7022, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 60740, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(42000);
var startupProbe = new ContainerGroupStartupProbe(15, 741, 3, 2, 10, exec, grpc, http, tcp);
var input = new ContainerGroupCreationRequest(true, container, "name", 236, ContainerRestartPolicy.Always, countryCodes, "dnvuzHu39", livenessProbe, networking, queueAutoscaler, queueConnection, readinessProbe, startupProbe);

var response = await client.ContainerGroups.CreateContainerGroupAsync(input, "acme-corp", "dev-env");

Console.WriteLine(response);
```

## GetContainerGroupAsync

Gets a container group

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}`

**Parameters**

| Name               | Type   | Required | Description                                                                                                                                                                                                                                         |
| :----------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName   | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName        | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName | string | ✅       | The unique container group name                                                                                                                                                                                                                     |

**Return Type**

`ContainerGroup`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.ContainerGroups.GetContainerGroupAsync("acme-corp", "dev-env", "mandlebrot");

Console.WriteLine(response);
```

## UpdateContainerGroupAsync

Updates a container group

- HTTP Method: `PATCH`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}`

**Parameters**

| Name               | Type                | Required | Description                                                                                                                                                                                                                                         |
| :----------------- | :------------------ | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input              | ContainerGroupPatch | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName   | string              | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName        | string              | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName | string              | ✅       | The unique container group name                                                                                                                                                                                                                     |

**Return Type**

`ContainerGroup`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var command = new List<string>() { "command" };
var axiom = new AxiomLoggingConfiguration("host", "api_token", "dataset");
var tagsItem = new DatadogTagForContainerLogging("name", "value");
var tags = new List<DatadogTagForContainerLogging>() { tagsItem };
var datadog = new DatadogLoggingConfiguration("host", "api_key", tags);
var headersItem = new ContainerLoggingHttpHeader("name", "value");
var headers = new List<ContainerLoggingHttpHeader>() { headersItem };
var http = new ContainerLoggingConfigurationHttp1("host", 17296, ContainerLoggingHttpFormat.Json, headers, ContainerLoggingHttpCompression.None, "user", "password", "path");
var newRelic = new NewRelicLoggingConfiguration("host", "ingestion_key");
var splunk = new ContainerLoggingSplunkConfiguration("host", "token");
var tcp = new TcpLoggingConfiguration("host", 35279);
var logging = new UpdateContainerLogging(axiom, datadog, http, newRelic, splunk, tcp);
var awsEcr = new ContainerRegistryAuthenticationAwsEcr("access_key_id", "secret_access_key");
var basic = new ContainerRegistryAuthenticationBasic("username", "password");
var dockerHub = new ContainerRegistryAuthenticationDockerHub("username", "personal_access_token");
var gcpGar = new ContainerRegistryAuthenticationGcpGar("service_key");
var gcpGcr = new ContainerRegistryAuthenticationGcpGcr("service_key");
var registryAuthentication = new ContainerRegistryAuthentication(awsEcr, basic, dockerHub, gcpGar, gcpGcr);
var gpuClasses = new List<string>() { "gpu_classes" };
var resources = new ContainerResourceUpdateSchema(10, 22157, gpuClasses, 53149991828);
var container = new UpdateContainer(command, new object(), "image", true, logging, ContainerGroupPriority.High, registryAuthentication, resources);
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var networking = new UpdateContainerGroupNetworking(43586);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(7022, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 60740, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(42000);
var livenessProbe = new ContainerGroupLivenessProbe(3, 208, 10, 1, 30, exec, grpc, http, tcp);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(7022, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 60740, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(42000);
var readinessProbe = new ContainerGroupReadinessProbe(3, 137, 1, 1, 1, exec, grpc, http, tcp);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(7022, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 60740, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(42000);
var startupProbe = new ContainerGroupStartupProbe(15, 741, 3, 2, 10, exec, grpc, http, tcp);
var queueAutoscaler = new QueueBasedAutoscalerConfiguration(65, 288, 21, 45, 56, 1604);
var input = new ContainerGroupPatch("be", container, 412, countryCodes, networking, livenessProbe, readinessProbe, startupProbe, queueAutoscaler);

var response = await client.ContainerGroups.UpdateContainerGroupAsync(input, "acme-corp", "dev-env", "mandlebrot");

Console.WriteLine(response);
```

## DeleteContainerGroupAsync

Deletes a container group

- HTTP Method: `DELETE`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}`

**Parameters**

| Name               | Type   | Required | Description                                                                                                                                                                                                                                         |
| :----------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName   | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName        | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName | string | ✅       | The unique container group name                                                                                                                                                                                                                     |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.DeleteContainerGroupAsync("acme-corp", "dev-env", "mandlebrot");
```

## StartContainerGroupAsync

Starts a container group

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/start`

**Parameters**

| Name               | Type   | Required | Description                                                                                                                                                                                                                                         |
| :----------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName   | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName        | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName | string | ✅       | The unique container group name                                                                                                                                                                                                                     |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.StartContainerGroupAsync("acme-corp", "dev-env", "mandlebrot");
```

## StopContainerGroupAsync

Stops a container group

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/stop`

**Parameters**

| Name               | Type   | Required | Description                                                                                                                                                                                                                                         |
| :----------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName   | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName        | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName | string | ✅       | The unique container group name                                                                                                                                                                                                                     |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.StopContainerGroupAsync("acme-corp", "dev-env", "mandlebrot");
```

## ListContainerGroupInstancesAsync

Gets the list of container group instances

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/instances`

**Parameters**

| Name               | Type   | Required | Description                                                                                                                                                                                                                                         |
| :----------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName   | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName        | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName | string | ✅       | The unique container group name                                                                                                                                                                                                                     |

**Return Type**

`ContainerGroupInstanceCollection`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.ContainerGroups.ListContainerGroupInstancesAsync("acme-corp", "dev-env", "mandlebrot");

Console.WriteLine(response);
```

## GetContainerGroupInstanceAsync

Gets a container group instance

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/instances/{container_group_instance_id}`

**Parameters**

| Name                     | Type   | Required | Description                                                                                                                                                                                                                                         |
| :----------------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName         | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName              | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName       | string | ✅       | The unique container group name                                                                                                                                                                                                                     |
| containerGroupInstanceId | string | ✅       | The unique container group instance identifier                                                                                                                                                                                                      |

**Return Type**

`ContainerGroupInstance`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.ContainerGroups.GetContainerGroupInstanceAsync("acme-corp", "dev-env", "mandlebrot", "db3a4591-efc3-46c0-b06a-3d820c0ec100");

Console.WriteLine(response);
```

## UpdateContainerGroupInstanceAsync

Updates a container group instance

- HTTP Method: `PATCH`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/instances/{container_group_instance_id}`

**Parameters**

| Name                     | Type                        | Required | Description                                                                                                                                                                                                                                         |
| :----------------------- | :-------------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input                    | ContainerGroupInstancePatch | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName         | string                      | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName              | string                      | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName       | string                      | ✅       | The unique container group name                                                                                                                                                                                                                     |
| containerGroupInstanceId | string                      | ✅       | The unique container group instance identifier                                                                                                                                                                                                      |

**Return Type**

`ContainerGroupInstance`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var input = new ContainerGroupInstancePatch(50399);

var response = await client.ContainerGroups.UpdateContainerGroupInstanceAsync(input, "acme-corp", "dev-env", "mandlebrot", "db3a4591-efc3-46c0-b06a-3d820c0ec100");

Console.WriteLine(response);
```

## ReallocateContainerGroupInstanceAsync

Reallocates a container group instance to run on a different Salad Node

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/instances/{container_group_instance_id}/reallocate`

**Parameters**

| Name                     | Type   | Required | Description                                                                                                                                                                                                                                         |
| :----------------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName         | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName              | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName       | string | ✅       | The unique container group name                                                                                                                                                                                                                     |
| containerGroupInstanceId | string | ✅       | The unique container group instance identifier                                                                                                                                                                                                      |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.ReallocateContainerGroupInstanceAsync("acme-corp", "dev-env", "mandlebrot", "db3a4591-efc3-46c0-b06a-3d820c0ec100");
```

## RecreateContainerGroupInstanceAsync

Stops a container, destroys it, and starts a new one without requiring the image to be downloaded again on a new Salad Node

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/instances/{container_group_instance_id}/recreate`

**Parameters**

| Name                     | Type   | Required | Description                                                                                                                                                                                                                                         |
| :----------------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName         | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName              | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName       | string | ✅       | The unique container group name                                                                                                                                                                                                                     |
| containerGroupInstanceId | string | ✅       | The unique container group instance identifier                                                                                                                                                                                                      |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.RecreateContainerGroupInstanceAsync("acme-corp", "dev-env", "mandlebrot", "db3a4591-efc3-46c0-b06a-3d820c0ec100");
```

## RestartContainerGroupInstanceAsync

Stops a container and restarts it on the same Salad Node

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/instances/{container_group_instance_id}/restart`

**Parameters**

| Name                     | Type   | Required | Description                                                                                                                                                                                                                                         |
| :----------------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName         | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName              | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName       | string | ✅       | The unique container group name                                                                                                                                                                                                                     |
| containerGroupInstanceId | string | ✅       | The unique container group instance identifier                                                                                                                                                                                                      |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.RestartContainerGroupInstanceAsync("acme-corp", "dev-env", "mandlebrot", "db3a4591-efc3-46c0-b06a-3d820c0ec100");
```
