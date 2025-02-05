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
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.Queues.ListQueuesAsync("z8lshc09tfagbfsl8ku-8hu25hwiw5a6dobimir3lfppusjbs", "ohun5ki");

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
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var input = new CreateQueue("name", "xN", "description");

var response = await client.Queues.CreateQueueAsync(input, "z8lshc09tfagbfsl8ku-8hu25hwiw5a6dobimir3lfppusjbs", "ohun5ki");

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
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.Queues.GetQueueAsync("vcald25asb53i96upv27f-nkhe1", "j6cwfayvsnaqsjq73vtxobiq9pxtqhnf3s0hg9gm", "vt");

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
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var input = new UpdateQueue("6XVt W", "description");

var response = await client.Queues.UpdateQueueAsync(input, "vcald25asb53i96upv27f-nkhe1", "j6cwfayvsnaqsjq73vtxobiq9pxtqhnf3s0hg9gm", "vt");

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
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.Queues.DeleteQueueAsync("vcald25asb53i96upv27f-nkhe1", "j6cwfayvsnaqsjq73vtxobiq9pxtqhnf3s0hg9gm", "vt");
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
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.Queues.ListQueueJobsAsync("fq0wo6novfjdzwlrie4vz30ajqzk-v6-gctcty9mhydvsq3", "mifj6w-lqsfbkn7h5yqw7l6vm-idada-k-zkc6zg", "lwd1wwfrdxt8y8y8pp161yh3", 492268819, 18);

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
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var input = new CreateQueueJob(new object {}, new object {}, "webhook");

var response = await client.Queues.CreateQueueJobAsync(input, "fq0wo6novfjdzwlrie4vz30ajqzk-v6-gctcty9mhydvsq3", "mifj6w-lqsfbkn7h5yqw7l6vm-idada-k-zkc6zg", "lwd1wwfrdxt8y8y8pp161yh3");

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
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.Queues.GetQueueJobAsync("oo-uft3mtt7tcxqcq1m0iarq", "b1qjwjc4vf99pxxwtres8z9zwaod8ipjrui87jo", "m2s0izl8d-g9wqh8bjget2tyh4q9ni9h81tilnlnf5i-r38a8vv5h4l", "queue_job_id");

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
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.Queues.DeleteQueueJobAsync("oo-uft3mtt7tcxqcq1m0iarq", "b1qjwjc4vf99pxxwtres8z9zwaod8ipjrui87jo", "m2s0izl8d-g9wqh8bjget2tyh4q9ni9h81tilnlnf5i-r38a8vv5h4l", "queue_job_id");
```
