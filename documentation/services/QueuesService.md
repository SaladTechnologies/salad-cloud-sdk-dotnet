# QueuesService

A list of all methods in the `QueuesService` service. Click on the method name to view detailed information about that method.

| Methods                                     | Description                                     |
| :------------------------------------------ | :---------------------------------------------- |
| [ListQueuesAsync](#listqueuesasync)         | Gets the list of queues in the given project.   |
| [CreateQueueAsync](#createqueueasync)       | Creates a new queue in the given project.       |
| [GetQueueAsync](#getqueueasync)             | Gets an existing queue in the given project.    |
| [UpdateQueueAsync](#updatequeueasync)       | Updates an existing queue in the given project. |
| [DeleteQueueAsync](#deletequeueasync)       | Deletes an existing queue in the given project. |
| [ListQueueJobsAsync](#listqueuejobsasync)   | Gets the list of jobs in a queue                |
| [CreateQueueJobAsync](#createqueuejobasync) | Creates a new job                               |
| [GetQueueJobAsync](#getqueuejobasync)       | Gets a job in a queue                           |
| [DeleteQueueJobAsync](#deletequeuejobasync) | Cancels a job in a queue                        |

## ListQueuesAsync

Gets the list of queues in the given project.

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues`

**Parameters**

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName      | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |

**Return Type**

`QueueList`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.Queues.ListQueuesAsync("xtp82b9jzwqov1insghigvfq0donadhrrdqx-2redu46g7e", "xk27gbnpmwk5xor49bk4ujk7");

Console.WriteLine(response);
```

## CreateQueueAsync

Creates a new queue in the given project.

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues`

**Parameters**

| Name             | Type        | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :---------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input            | CreateQueue | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName | string      | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName      | string      | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |

**Return Type**

`Queue`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new CreateQueue("ho4d79h7bg0vpngqc8hz5pxjwi");

var response = await client.Queues.CreateQueueAsync(input, "xtp82b9jzwqov1insghigvfq0donadhrrdqx-2redu46g7e", "xk27gbnpmwk5xor49bk4ujk7");

Console.WriteLine(response);
```

## GetQueueAsync

Gets an existing queue in the given project.

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}`

**Parameters**

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName      | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| queueName        | string | ✅       | The queue name.                                                                                                                                                                                                                                     |

**Return Type**

`Queue`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.Queues.GetQueueAsync("bb5wprcvb9628akhug9lnd2", "bw-4bdb9jsi-f1xex70mdgjf5n-5ua-e28xyu9ujbls0vsy", "wilo12xl52y9c178cmdya6ykpby-hunb0b6s7s2l");

Console.WriteLine(response);
```

## UpdateQueueAsync

Updates an existing queue in the given project.

- HTTP Method: `PATCH`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}`

**Parameters**

| Name             | Type        | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :---------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input            | UpdateQueue | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName | string      | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName      | string      | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| queueName        | string      | ✅       | The queue name.                                                                                                                                                                                                                                     |

**Return Type**

`Queue`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new UpdateQueue();

var response = await client.Queues.UpdateQueueAsync(input, "bb5wprcvb9628akhug9lnd2", "bw-4bdb9jsi-f1xex70mdgjf5n-5ua-e28xyu9ujbls0vsy", "wilo12xl52y9c178cmdya6ykpby-hunb0b6s7s2l");

Console.WriteLine(response);
```

## DeleteQueueAsync

Deletes an existing queue in the given project.

- HTTP Method: `DELETE`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}`

**Parameters**

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName      | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| queueName        | string | ✅       | The queue name.                                                                                                                                                                                                                                     |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

await client.Queues.DeleteQueueAsync("bb5wprcvb9628akhug9lnd2", "bw-4bdb9jsi-f1xex70mdgjf5n-5ua-e28xyu9ujbls0vsy", "wilo12xl52y9c178cmdya6ykpby-hunb0b6s7s2l");
```

## ListQueueJobsAsync

Gets the list of jobs in a queue

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}/jobs`

**Parameters**

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName      | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| queueName        | string | ✅       | The queue name.                                                                                                                                                                                                                                     |
| page             | long   | ❌       | The page number                                                                                                                                                                                                                                     |
| pageSize         | long   | ❌       | The number of items per page                                                                                                                                                                                                                        |

**Return Type**

`QueueJobList`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.Queues.ListQueueJobsAsync("wcaz2jbu5pfmpygxffsf4bh4e6", "dzh9lv6afpamv8cx0x6", "s9f4ikmr0j6c3n18n4djttkqmgzb46dd5wogzrfe2pq12s2", 706148771, 45);

Console.WriteLine(response);
```

## CreateQueueJobAsync

Creates a new job

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}/jobs`

**Parameters**

| Name             | Type           | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input            | CreateQueueJob | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName | string         | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName      | string         | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| queueName        | string         | ✅       | The queue name.                                                                                                                                                                                                                                     |

**Return Type**

`QueueJob`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new CreateQueueJob(new object {});

var response = await client.Queues.CreateQueueJobAsync(input, "wcaz2jbu5pfmpygxffsf4bh4e6", "dzh9lv6afpamv8cx0x6", "s9f4ikmr0j6c3n18n4djttkqmgzb46dd5wogzrfe2pq12s2");

Console.WriteLine(response);
```

## GetQueueJobAsync

Gets a job in a queue

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}/jobs/{queue_job_id}`

**Parameters**

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName      | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| queueName        | string | ✅       | The queue name.                                                                                                                                                                                                                                     |
| queueJobId       | string | ✅       | The job identifier. This is automatically generated and assigned when the job is created.                                                                                                                                                           |

**Return Type**

`QueueJob`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.Queues.GetQueueJobAsync("zm-jv", "tq26", "je5dpzbgsk8gvp", "queue_job_id");

Console.WriteLine(response);
```

## DeleteQueueJobAsync

Cancels a job in a queue

- HTTP Method: `DELETE`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/queues/{queue_name}/jobs/{queue_job_id}`

**Parameters**

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName      | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| queueName        | string | ✅       | The queue name.                                                                                                                                                                                                                                     |
| queueJobId       | string | ✅       | The job identifier. This is automatically generated and assigned when the job is created.                                                                                                                                                           |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

await client.Queues.DeleteQueueJobAsync("zm-jv", "tq26", "je5dpzbgsk8gvp", "queue_job_id");
```
