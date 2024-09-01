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

var response = await client.ContainerGroups.ListContainerGroupsAsync("ep7fgeqvy6vfd66h1ewe-69h", "dpdhw0h4i3hwpdzw9");

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

var resources = new ContainerResourceRequirements(6, 8938);
var container = new CreateContainer("magna laboris exercitation sunt", resources);
var input = new CreateContainerGroup("vgm3", container, false, ContainerRestartPolicy.Always, 21);

var response = await client.ContainerGroups.CreateContainerGroupAsync(input, "ep7fgeqvy6vfd66h1ewe-69h", "dpdhw0h4i3hwpdzw9");

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

var response = await client.ContainerGroups.GetContainerGroupAsync("zt-dvmb-gmo5a", "enqsq6na2w8d2wlvk-85d3jxhjhj", "fcixv6oyiqlk");

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

var response = await client.ContainerGroups.UpdateContainerGroupAsync(input, "zt-dvmb-gmo5a", "enqsq6na2w8d2wlvk-85d3jxhjhj", "fcixv6oyiqlk");

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

await client.ContainerGroups.DeleteContainerGroupAsync("zt-dvmb-gmo5a", "enqsq6na2w8d2wlvk-85d3jxhjhj", "fcixv6oyiqlk");
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

await client.ContainerGroups.StartContainerGroupAsync("sm3eup0iqixen33w3mp1ln15pix00azjaxgfnuon5rnc", "kyp6oi0404lk6h", "ucuerglkiabi4sbb23l56oq87j1v654hdchyg-8n5glaql3-539c");
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

await client.ContainerGroups.StopContainerGroupAsync("tytntnk7-le269faihpgelqal6jc7327027puoxjag6lmdgb0c3qeelc", "s1m84-o8x59", "t96e3mcxix0izfrbhlu3evx");
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

var response = await client.ContainerGroups.ListContainerGroupInstancesAsync("i5dt471e81flms65ujlnugscfp5-4x1xl1-c1ax257sioy7vldsm", "hwxbxx0fdtl98ziqbie46xqcbddvaoe06qhpuoplm89wi1", "y4q9cpfigd95ewlngasgx2e93zxeimrri0-iro9w0j3jvvgj2awj6-0ivo87g");

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

var response = await client.ContainerGroups.GetContainerGroupInstanceAsync("cce0i3", "bb53k", "vtsp-47yvqix7", "container_group_instance_id");

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

await client.ContainerGroups.ReallocateContainerGroupInstanceAsync("e1831z2sf2i9bk6n01-l4p5c2u", "h86701y3xcmm3m3c1oqx1cbz9zmgggid8ddvtm74etd0oedpgesup", "zpw3lnw7ag07-nla57", "container_group_instance_id");
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

await client.ContainerGroups.RecreateContainerGroupInstanceAsync("xzg6rr4bm5841gi0z8-206cdrb7o1", "p6ls0enipujsrco8ums89jy5ldm9v9wniwlzg156f7f4hj66c1pcdqiziv", "lrb4rg8t0zwxs2l1ja3src79wfm1p-s-dl9lt39rn", "container_group_instance_id");
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

await client.ContainerGroups.RestartContainerGroupInstanceAsync("pwt3jkl-373gjha9x4b8jfvgcvy-5z9eei5vo7ho3lx9fwf", "b6guf5mbszj1pjm7bnkx94c6wxjsm11-6l9gj1w78dzugvi1ay", "g3nf416-xd0f74r83g8t-3gf0nk0-ksf6kohlh6m-flte85e", "container_group_instance_id");
```
