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

`ContainerGroupList`

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

| Name             | Type                 | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input            | CreateContainerGroup | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName | string               | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName      | string               | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |

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
var resources = new ContainerResourceRequirements(13, 8139, gpuClasses, 18886859746);
var command = new List<string>() { "command" };
var axiom = new LoggingAxiom2("host", "api_token", "dataset");
var tagsItem = new DatadogTags2("name", "value");
var tags = new List<DatadogTags2>() { tagsItem };
var datadog = new LoggingDatadog2("host", "api_key", tags);
var newRelic = new LoggingNewRelic2("host", "ingestion_key");
var splunk = new LoggingSplunk2("host", "token");
var tcp = new LoggingTcp2("host", 32655);
var headersItem = new HttpHeaders3("name", "value");
var headers = new List<HttpHeaders3>() { headersItem };
var http = new LoggingHttp2("host", 35374, HttpFormat2.Json, HttpCompression2.None, "user", "password", "path", headers);
var logging = new CreateContainerLogging(axiom, datadog, newRelic, splunk, tcp, http);
var basic = new RegistryAuthenticationBasic1("username", "password");
var gcpGcr = new RegistryAuthenticationGcpGcr1("service_key");
var awsEcr = new RegistryAuthenticationAwsEcr1("access_key_id", "secret_access_key");
var dockerHub = new RegistryAuthenticationDockerHub1("username", "personal_access_token");
var gcpGar = new RegistryAuthenticationGcpGar1("service_key");
var registryAuthentication = new CreateContainerRegistryAuthentication(basic, gcpGcr, awsEcr, dockerHub, gcpGar);
var container = new CreateContainer("image", resources, command, ContainerGroupPriority.High, new object(), logging, registryAuthentication, true);
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var networking = new CreateContainerGroupNetworking(ContainerNetworkingProtocol.Http, 16805, true, CreateContainerGroupNetworkingLoadBalancer.RoundRobin, true, 100000, 100000);
var tcp = new ContainerGroupProbeTcp(22350);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 56884, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 47172);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var livenessProbe = new ContainerGroupLivenessProbe(0, 10, 30, 1, 3, tcp, http, grpc, exec);
var tcp = new ContainerGroupProbeTcp(22350);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 56884, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 47172);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var readinessProbe = new ContainerGroupReadinessProbe(0, 1, 1, 1, 3, tcp, http, grpc, exec);
var tcp = new ContainerGroupProbeTcp(22350);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 56884, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 47172);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var startupProbe = new ContainerGroupStartupProbe(9, 3, 10, 2, 1200, tcp, http, grpc, exec);
var queueConnection = new ContainerGroupQueueConnection("path", 34605, "gv8rketqh");
var queueAutoscaler = new QueueAutoscaler(26, 55, 42, 442, 3, 69);
var input = new CreateContainerGroup("name", container, false, ContainerRestartPolicy.Always, 291, "kV", countryCodes, networking, livenessProbe, readinessProbe, startupProbe, queueConnection, queueAutoscaler);

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

var response = await client.ContainerGroups.GetContainerGroupAsync("acme-corp", "dev-env", "ja8mepeueo5-1hcilmn8m1ouq40vp547cf-8");

Console.WriteLine(response);
```

## UpdateContainerGroupAsync

Updates a container group

- HTTP Method: `PATCH`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}`

**Parameters**

| Name               | Type                 | Required | Description                                                                                                                                                                                                                                         |
| :----------------- | :------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input              | UpdateContainerGroup | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName   | string               | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName        | string               | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName | string               | ✅       | The unique container group name                                                                                                                                                                                                                     |

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
var resources1 = new Resources(9, 13952, gpuClasses, 50215025854);
var command = new List<string>() { "command" };
var axiom = new LoggingAxiom3("host", "api_token", "dataset");
var tagsItem = new DatadogTags3("name", "value");
var tags = new List<DatadogTags3>() { tagsItem };
var datadog = new LoggingDatadog3("host", "api_key", tags);
var newRelic = new LoggingNewRelic3("host", "ingestion_key");
var splunk = new LoggingSplunk3("host", "token");
var tcp = new LoggingTcp3("host", 34769);
var headersItem = new HttpHeaders4("name", "value");
var headers = new List<HttpHeaders4>() { headersItem };
var http = new LoggingHttp3("host", 17361, HttpFormat3.Json, HttpCompression3.None, "user", "password", "path", headers);
var logging = new UpdateContainerLogging(axiom, datadog, newRelic, splunk, tcp, http);
var basic = new RegistryAuthenticationBasic2("username", "password");
var gcpGcr = new RegistryAuthenticationGcpGcr2("service_key");
var awsEcr = new RegistryAuthenticationAwsEcr2("access_key_id", "secret_access_key");
var dockerHub = new RegistryAuthenticationDockerHub2("username", "personal_access_token");
var gcpGar = new RegistryAuthenticationGcpGar2("service_key");
var registryAuthentication = new UpdateContainerRegistryAuthentication(basic, gcpGcr, awsEcr, dockerHub, gcpGar);
var container = new UpdateContainer("image", resources1, command, ContainerGroupPriority.High, new object(), logging, registryAuthentication, true);
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var networking = new UpdateContainerGroupNetworking(55354);
var tcp = new ContainerGroupProbeTcp(22350);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 56884, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 47172);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var livenessProbe = new ContainerGroupLivenessProbe(0, 10, 30, 1, 3, tcp, http, grpc, exec);
var tcp = new ContainerGroupProbeTcp(22350);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 56884, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 47172);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var readinessProbe = new ContainerGroupReadinessProbe(0, 1, 1, 1, 3, tcp, http, grpc, exec);
var tcp = new ContainerGroupProbeTcp(22350);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 56884, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 47172);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var startupProbe = new ContainerGroupStartupProbe(9, 3, 10, 2, 1200, tcp, http, grpc, exec);
var queueAutoscaler = new QueueAutoscaler(26, 55, 42, 442, 3, 69);
var input = new UpdateContainerGroup("Kme,2D", container, 12, countryCodes, networking, livenessProbe, readinessProbe, startupProbe, queueAutoscaler);

var response = await client.ContainerGroups.UpdateContainerGroupAsync(input, "acme-corp", "dev-env", "ja8mepeueo5-1hcilmn8m1ouq40vp547cf-8");

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

await client.ContainerGroups.DeleteContainerGroupAsync("acme-corp", "dev-env", "ja8mepeueo5-1hcilmn8m1ouq40vp547cf-8");
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

await client.ContainerGroups.StartContainerGroupAsync("acme-corp", "dev-env", "cuwm1y388-m7ehzirdxyvm-4yjt2qfdlzsuvite9");
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

await client.ContainerGroups.StopContainerGroupAsync("acme-corp", "dev-env", "x5pfkx3zz5np0cn9u94xdcf5g5w9-1");
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

`ContainerGroupInstances`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.ContainerGroups.ListContainerGroupInstancesAsync("acme-corp", "dev-env", "o-41alirjhsw60");

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
| containerGroupInstanceId | string | ✅       | The unique instance identifier                                                                                                                                                                                                                      |

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

var response = await client.ContainerGroups.GetContainerGroupInstanceAsync("acme-corp", "dev-env", "djh4s8hz0soygun3m687oust14ot1pk0icevxf5izkd-rds", "container_group_instance_id");

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
| containerGroupInstanceId | string | ✅       | The unique instance identifier                                                                                                                                                                                                                      |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.ReallocateContainerGroupInstanceAsync("acme-corp", "dev-env", "rlr6585lj2n", "container_group_instance_id");
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
| containerGroupInstanceId | string | ✅       | The unique instance identifier                                                                                                                                                                                                                      |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.RecreateContainerGroupInstanceAsync("acme-corp", "dev-env", "n8-fjfpg-8o880hinx8ob81zddo5rum25m5fl-ocry41fabtao7", "container_group_instance_id");
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
| containerGroupInstanceId | string | ✅       | The unique instance identifier                                                                                                                                                                                                                      |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.RestartContainerGroupInstanceAsync("acme-corp", "dev-env", "p1adeb-w3gjttgd7m2r1wt99qo455", "container_group_instance_id");
```
