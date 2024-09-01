# QueuesService

A list of all methods in the `QueuesService` service. Click on the method name to view detailed information about that method.

| Methods                                     | Description                    |
| :------------------------------------------ | :----------------------------- |
| [ListQueuesAsync](#listqueuesasync)         | Gets the list of queues        |
| [CreateQueueAsync](#createqueueasync)       | Creates a new queue            |
| [GetQueueAsync](#getqueueasync)             | Gets a queue                   |
| [UpdateQueueAsync](#updatequeueasync)       | Updates a queue                |
| [DeleteQueueAsync](#deletequeueasync)       | Deletes a queue                |
| [ListQueueJobsAsync](#listqueuejobsasync)   | Retrieves a list of queue jobs |
| [CreateQueueJobAsync](#createqueuejobasync) | Creates a new job              |
| [GetQueueJobAsync](#getqueuejobasync)       | Retrieves a job in a queue     |
| [DeleteQueueJobAsync](#deletequeuejobasync) | Deletes a queue job            |

## ListQueuesAsync

Gets the list of queues

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues`

**Parameters**

| Name             | Type   | Required | Description                  |
| :--------------- | :----- | :------- | :--------------------------- |
| organizationName | string | ✅       | The unique organization name |
| projectName      | string | ✅       | The unique project name      |

**Return Type**

`QueueList`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Queues.ListQueuesAsync("rtxaydgbmb5wprcvb9628akhug9lnd3c0", "p4bdb9jsi-f1xex70mdgjf5n-5ua-e28xyu9ujbls0vsz6xilo12xl52y9c177");

Console.WriteLine(response);
```

## CreateQueueAsync

Creates a new queue

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues`

**Parameters**

| Name             | Type        | Required | Description                  |
| :--------------- | :---------- | :------- | :--------------------------- |
| input            | CreateQueue | ✅       | The request body.            |
| organizationName | string      | ✅       | The unique organization name |
| projectName      | string      | ✅       | The unique project name      |

**Return Type**

`Queue`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new CreateQueue("wcaz2jbu5pfmpygxffsf4bh4e6");

var response = await client.Queues.CreateQueueAsync(input, "rtxaydgbmb5wprcvb9628akhug9lnd3c0", "p4bdb9jsi-f1xex70mdgjf5n-5ua-e28xyu9ujbls0vsz6xilo12xl52y9c177");

Console.WriteLine(response);
```

## GetQueueAsync

Gets a queue

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}`

**Parameters**

| Name             | Type   | Required | Description                  |
| :--------------- | :----- | :------- | :--------------------------- |
| organizationName | string | ✅       | The unique organization name |
| projectName      | string | ✅       | The unique project name      |
| queueName        | string | ✅       | The unique queue name        |

**Return Type**

`Queue`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Queues.GetQueueAsync("g1bq27ohe5dpzbgsk8gvpuhecson4k2eclxss3", "wtxd1j0ixuhfk-hdff3n3-hbtsigyh53bt0g4gjh8mcz4", "bnkfiyt3k5ke3wy-5gl1809r");

Console.WriteLine(response);
```

## UpdateQueueAsync

Updates a queue

- HTTP Method: `PATCH`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}`

**Parameters**

| Name             | Type        | Required | Description                  |
| :--------------- | :---------- | :------- | :--------------------------- |
| input            | UpdateQueue | ✅       | The request body.            |
| organizationName | string      | ✅       | The unique organization name |
| projectName      | string      | ✅       | The unique project name      |
| queueName        | string      | ✅       | The unique queue name        |

**Return Type**

`Queue`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new UpdateQueue();

var response = await client.Queues.UpdateQueueAsync(input, "g1bq27ohe5dpzbgsk8gvpuhecson4k2eclxss3", "wtxd1j0ixuhfk-hdff3n3-hbtsigyh53bt0g4gjh8mcz4", "bnkfiyt3k5ke3wy-5gl1809r");

Console.WriteLine(response);
```

## DeleteQueueAsync

Deletes a queue

- HTTP Method: `DELETE`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}`

**Parameters**

| Name             | Type   | Required | Description                  |
| :--------------- | :----- | :------- | :--------------------------- |
| organizationName | string | ✅       | The unique organization name |
| projectName      | string | ✅       | The unique project name      |
| queueName        | string | ✅       | The unique queue name        |

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

await client.Queues.DeleteQueueAsync("g1bq27ohe5dpzbgsk8gvpuhecson4k2eclxss3", "wtxd1j0ixuhfk-hdff3n3-hbtsigyh53bt0g4gjh8mcz4", "bnkfiyt3k5ke3wy-5gl1809r");
```

## ListQueueJobsAsync

Retrieves a list of queue jobs

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}/jobs`

**Parameters**

| Name             | Type   | Required | Description                  |
| :--------------- | :----- | :------- | :--------------------------- |
| organizationName | string | ✅       | The unique organization name |
| projectName      | string | ✅       | The unique project name      |
| queueName        | string | ✅       | The unique queue name        |
| page             | long   | ❌       | The page number              |
| pageSize         | long   | ❌       | The number of items per page |

**Return Type**

`QueueJobList`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Queues.ListQueueJobsAsync("jb7eyumc25lm4prwopvwr-1961g-m85nbqda3ufs", "sn780t45z2tw4xt1b86w0clx6vkq-3", "sx811v32aty9s-ghx1hm2nw1mhgooidhvnhwadaqzuh19krhv62or5c", 2110014563, 23);

Console.WriteLine(response);
```

## CreateQueueJobAsync

Creates a new job

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}/jobs`

**Parameters**

| Name             | Type           | Required | Description                  |
| :--------------- | :------------- | :------- | :--------------------------- |
| input            | CreateQueueJob | ✅       | The request body.            |
| organizationName | string         | ✅       | The unique organization name |
| projectName      | string         | ✅       | The unique project name      |
| queueName        | string         | ✅       | The unique queue name        |

**Return Type**

`QueueJob`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new CreateQueueJob(new object {});

var response = await client.Queues.CreateQueueJobAsync(input, "jb7eyumc25lm4prwopvwr-1961g-m85nbqda3ufs", "sn780t45z2tw4xt1b86w0clx6vkq-3", "sx811v32aty9s-ghx1hm2nw1mhgooidhvnhwadaqzuh19krhv62or5c");

Console.WriteLine(response);
```

## GetQueueJobAsync

Retrieves a job in a queue

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}/jobs/{queue_job_id}`

**Parameters**

| Name             | Type   | Required | Description                  |
| :--------------- | :----- | :------- | :--------------------------- |
| organizationName | string | ✅       | The unique organization name |
| projectName      | string | ✅       | The unique project name      |
| queueName        | string | ✅       | The unique queue name        |
| queueJobId       | string | ✅       | The unique job id            |

**Return Type**

`QueueJob`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Queues.GetQueueJobAsync("j-8sae7t0u7o0emyztq64o8ut710qtepjztx34mk6lruecseiyq06ab3ok5xr", "eokxas9m7y892q4m5rifzmevenpg1vot8xgbal184sloim-c7555huym18dia9d", "zbvvpn2qgtohp", "queue_job_id");

Console.WriteLine(response);
```

## DeleteQueueJobAsync

Deletes a queue job

- HTTP Method: `DELETE`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}/jobs/{queue_job_id}`

**Parameters**

| Name             | Type   | Required | Description                  |
| :--------------- | :----- | :------- | :--------------------------- |
| organizationName | string | ✅       | The unique organization name |
| projectName      | string | ✅       | The unique project name      |
| queueName        | string | ✅       | The unique queue name        |
| queueJobId       | string | ✅       | The unique job id            |

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

await client.Queues.DeleteQueueJobAsync("j-8sae7t0u7o0emyztq64o8ut710qtepjztx34mk6lruecseiyq06ab3ok5xr", "eokxas9m7y892q4m5rifzmevenpg1vot8xgbal184sloim-c7555huym18dia9d", "zbvvpn2qgtohp", "queue_job_id");
```
