# QueuesService

A list of all methods in the `QueuesService` service. Click on the method name to view detailed information about that method.

| Methods                                     | Description                                     |
| :------------------------------------------ | :---------------------------------------------- |
| [ListQueuesAsync](#listqueuesasync)         | Gets the list of queues in the given project.   |
| [CreateQueueAsync](#createqueueasync)       | Creates a new queue in the given project.       |
| [GetQueueAsync](#getqueueasync)             | Gets an existing queue in the given project.    |
| [UpdateQueueAsync](#updatequeueasync)       | Updates an existing queue in the given project. |
| [DeleteQueueAsync](#deletequeueasync)       | Deletes an existing queue in the given project. |
| [ListQueueJobsAsync](#listqueuejobsasync)   | Retrieves a list of queue jobs                  |
| [CreateQueueJobAsync](#createqueuejobasync) | Creates a new job                               |
| [GetQueueJobAsync](#getqueuejobasync)       | Retrieves a job in a queue                      |
| [DeleteQueueJobAsync](#deletequeuejobasync) | Deletes a queue job                             |

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Queues.ListQueuesAsync("lwt38wqx9ycbbwq7cz7enua", "i5ohrcyvt0ap8jxyjtw5spbfh7ukelysoi13iija9co");

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
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new CreateQueue("ykm2ls08p3lv");

var response = await client.Queues.CreateQueueAsync(input, "lwt38wqx9ycbbwq7cz7enua", "i5ohrcyvt0ap8jxyjtw5spbfh7ukelysoi13iija9co");

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Queues.GetQueueAsync("voe5nrfsnef63doc193sgdihl8bgcxw201b7qbn", "xlauk07eld4q4sm9jdgi4bgl1flz0elvw26099ougowft9j-kjp6bahz155", "gsomvfqk5h4gbc8o3p4id29bdadte3m51it2hfzxfmyjtvnd0b");

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
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new UpdateQueue();

var response = await client.Queues.UpdateQueueAsync(input, "voe5nrfsnef63doc193sgdihl8bgcxw201b7qbn", "xlauk07eld4q4sm9jdgi4bgl1flz0elvw26099ougowft9j-kjp6bahz155", "gsomvfqk5h4gbc8o3p4id29bdadte3m51it2hfzxfmyjtvnd0b");

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

await client.Queues.DeleteQueueAsync("voe5nrfsnef63doc193sgdihl8bgcxw201b7qbn", "xlauk07eld4q4sm9jdgi4bgl1flz0elvw26099ougowft9j-kjp6bahz155", "gsomvfqk5h4gbc8o3p4id29bdadte3m51it2hfzxfmyjtvnd0b");
```

## ListQueueJobsAsync

Retrieves a list of queue jobs

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Queues.ListQueueJobsAsync("qiqiazzthr12lsqkk1iq35-ix3pzbff9-f8x8ls569n71", "ht3-tiei7j9ye5yzdixjzbx5ywjbd", "xp465rhqkyqstwpk8kd3jy5kakai4lollggq7i7xz97", 1955049824, 95);

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
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new CreateQueueJob(new object {});

var response = await client.Queues.CreateQueueJobAsync(input, "qiqiazzthr12lsqkk1iq35-ix3pzbff9-f8x8ls569n71", "ht3-tiei7j9ye5yzdixjzbx5ywjbd", "xp465rhqkyqstwpk8kd3jy5kakai4lollggq7i7xz97");

Console.WriteLine(response);
```

## GetQueueJobAsync

Retrieves a job in a queue

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Queues.GetQueueJobAsync("erx15rey11qozndq25fyep9cx1pky-znnuxifqcep9-zc", "x9-4z-1rr438ze1lo349hdscooit-lme54jb98rdf4itla-wc6aace", "e-tvw-8ybw4mj2a", "queue_job_id");

Console.WriteLine(response);
```

## DeleteQueueJobAsync

Deletes a queue job

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
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

await client.Queues.DeleteQueueJobAsync("erx15rey11qozndq25fyep9cx1pky-znnuxifqcep9-zc", "x9-4z-1rr438ze1lo349hdscooit-lme54jb98rdf4itla-wc6aace", "e-tvw-8ybw4mj2a", "queue_job_id");
```
