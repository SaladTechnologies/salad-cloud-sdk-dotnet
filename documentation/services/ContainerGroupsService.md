# ContainerGroupsService

A list of all methods in the `ContainerGroupsService` service. Click on the method name to view detailed information about that method.

| Methods                                                                         | Description                                                                                                              |
| :------------------------------------------------------------------------------ | :----------------------------------------------------------------------------------------------------------------------- |
| [ListContainerGroupsAsync](#listcontainergroupsasync)                           | Gets the list of container groups                                                                                        |
| [CreateContainerGroupAsync](#createcontainergroupasync)                         | Creates a new container group                                                                                            |
| [GetContainerGroupAsync](#getcontainergroupasync)                               | Gets a container group                                                                                                   |
| [UpdateContainerGroupAsync](#updatecontainergroupasync)                         | Updates a container group                                                                                                |
| [DeleteContainerGroupAsync](#deletecontainergroupasync)                         | Deletes a container group                                                                                                |
| [StartContainerGroupAsync](#startcontainergroupasync)                           | Starts a container group                                                                                                 |
| [StopContainerGroupAsync](#stopcontainergroupasync)                             | Stops a container group                                                                                                  |
| [ListContainerGroupInstancesAsync](#listcontainergroupinstancesasync)           | Retrieves a list of container group instances                                                                            |
| [GetContainerGroupInstanceAsync](#getcontainergroupinstanceasync)               | Retrieves the details of a single instance within a container group by instance ID                                       |
| [ReallocateContainerGroupInstanceAsync](#reallocatecontainergroupinstanceasync) | Remove a node from a workload and reallocate the workload to a different node                                            |
| [RecreateContainerGroupInstanceAsync](#recreatecontainergroupinstanceasync)     | Stops a container, destroys it, creates a new one without requiring the image to be downloaded again on a different node |
| [RestartContainerGroupInstanceAsync](#restartcontainergroupinstanceasync)       | Restarts a workload on a node without reallocating it                                                                    |

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.ListContainerGroupsAsync("v50imwzgi4em4q035", "m6yw3-xm60cb7tiev8rketqiiwjepibzf2ust1cvjx8oua8mepeueo5-1");

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
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var resources = new ContainerResourceRequirements(10, 17858);
var container = new CreateContainer("velit qui cillum veniam ullamco", resources);
var input = new CreateContainerGroup("oh2mpxyfojt-6cco", container, false, ContainerRestartPolicy.Always, 225);

var response = await client.ContainerGroups.CreateContainerGroupAsync(input, "v50imwzgi4em4q035", "m6yw3-xm60cb7tiev8rketqiiwjepibzf2ust1cvjx8oua8mepeueo5-1");

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.GetContainerGroupAsync("ob3ca5hduqlb1uzytbhhukf1u0-ahl0b9oqfjj0q", "x7dvdopv2czgde1zrufxgiv5tp-kncd4gfzda9ik-lx71", "cif9b1yvozs9trd4v0bll7qwslfehyhnfadnjp2w52gwrm0urjjj5b9hbe2fr6f");

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
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new UpdateContainerGroup();

var response = await client.ContainerGroups.UpdateContainerGroupAsync(input, "ob3ca5hduqlb1uzytbhhukf1u0-ahl0b9oqfjj0q", "x7dvdopv2czgde1zrufxgiv5tp-kncd4gfzda9ik-lx71", "cif9b1yvozs9trd4v0bll7qwslfehyhnfadnjp2w52gwrm0urjjj5b9hbe2fr6f");

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

await client.ContainerGroups.DeleteContainerGroupAsync("ob3ca5hduqlb1uzytbhhukf1u0-ahl0b9oqfjj0q", "x7dvdopv2czgde1zrufxgiv5tp-kncd4gfzda9ik-lx71", "cif9b1yvozs9trd4v0bll7qwslfehyhnfadnjp2w52gwrm0urjjj5b9hbe2fr6f");
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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

await client.ContainerGroups.StartContainerGroupAsync("uh5upyur493wxwbxrj4xt9wfx07sgyz1fs97sfhtue78-54vdogp2qrcnt-8a", "v7jhy3jn2rdf012fi7ouno3mk9", "a4d0ajj5ajjquzeg-z3kvqxtnoxnlzhjhjt-8naw");
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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

await client.ContainerGroups.StopContainerGroupAsync("c0o0gqev-mnkpy8af-s7rq68p2lenu8izbg09xnu6-fkv4dta4yd", "rpi16e4ddle58fi8u9w2qgnsgj7cnci4p90a72aagy0f001ws1rwna83a3asuz", "fd6ugn07m5xpcp89lefemdke05z4s9eg1d2caksvlhpzm");
```

## ListContainerGroupInstancesAsync

Retrieves a list of container group instances

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.ListContainerGroupInstancesAsync("dcbh1", "pdcapp3enb9gd2f4k49vviu53s67ckwwnxsd-gfjsmuxcljdg4t1zzyoj", "vl2kuh4c67m3ae7qwlwipkdye-ad");

Console.WriteLine(response);
```

## GetContainerGroupInstanceAsync

Retrieves the details of a single instance within a container group by instance ID

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.GetContainerGroupInstanceAsync("b0up7kyr7vabeivb96iwcvlvvm1n", "ngljb", "xtp82b9jzwqov1insghigvfq0donadhrrdqx-2redu46g7e", "container_group_instance_id");

Console.WriteLine(response);
```

## ReallocateContainerGroupInstanceAsync

Remove a node from a workload and reallocate the workload to a different node

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

await client.ContainerGroups.ReallocateContainerGroupInstanceAsync("xk27gbnpmwk5xor49bk4ujk7", "cy1l6xj-5vzihwp4ho850l3faynnuq71ru6y", "mgza-e8llajq25o36x8b-38phh", "container_group_instance_id");
```

## RecreateContainerGroupInstanceAsync

Stops a container, destroys it, creates a new one without requiring the image to be downloaded again on a different node

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

await client.ContainerGroups.RecreateContainerGroupInstanceAsync("pkfh3rhnvt4x30k5t", "o7r3q30xz", "aq7hd1fjfxgtq8uehil3eplo", "container_group_instance_id");
```

## RestartContainerGroupInstanceAsync

Restarts a workload on a node without reallocating it

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

await client.ContainerGroups.RestartContainerGroupInstanceAsync("kd79h7bg0vpngqc8hz5pxjwi7muqnmuuqsx3q3zm2hxkci5yv6kho", "u5ljgqmbs6a7s", "qmq3nj6oy8b2wpzbidnelidy9s6k9w", "container_group_instance_id");
```
