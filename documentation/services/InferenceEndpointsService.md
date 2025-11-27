# InferenceEndpointsService

A list of all methods in the `InferenceEndpointsService` service. Click on the method name to view detailed information about that method.

| Methods                                                             | Description                           |
| :------------------------------------------------------------------ | :------------------------------------ |
| [ListInferenceEndpointsAsync](#listinferenceendpointsasync)         | Lists inference endpoints.            |
| [GetInferenceEndpointAsync](#getinferenceendpointasync)             | Gets an inference endpoint.           |
| [ListInferenceEndpointJobsAsync](#listinferenceendpointjobsasync)   | Lists inference endpoint jobs.        |
| [CreateInferenceEndpointJobAsync](#createinferenceendpointjobasync) | Creates a new inference endpoint job. |
| [GetInferenceEndpointJobAsync](#getinferenceendpointjobasync)       | Gets an inference endpoint job.       |
| [DeleteInferenceEndpointJobAsync](#deleteinferenceendpointjobasync) | Cancels an inference endpoint job.    |

## ListInferenceEndpointsAsync

Lists inference endpoints.

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/inference-endpoints`

**Parameters**

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| page             | long   | ❌       | The page number.                                                                                                                                                                                                                                    |
| pageSize         | long   | ❌       | The maximum number of items per page.                                                                                                                                                                                                               |

**Return Type**

`InferenceEndpointCollection`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var response = await client.InferenceEndpoints.ListInferenceEndpointsAsync("acme-corp", 1, 1);

Console.WriteLine(response);
```

## GetInferenceEndpointAsync

Gets an inference endpoint.

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}`

**Parameters**

| Name                  | Type   | Required | Description                                                                                                                                                                                                                                         |
| :-------------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName      | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| inferenceEndpointName | string | ✅       | The inference endpoint name.                                                                                                                                                                                                                        |

**Return Type**

`InferenceEndpoint`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var response = await client.InferenceEndpoints.GetInferenceEndpointAsync("acme-corp", "transcribe");

Console.WriteLine(response);
```

## ListInferenceEndpointJobsAsync

Lists inference endpoint jobs.

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs`

**Parameters**

| Name                  | Type   | Required | Description                                                                                                                                                                                                                                         |
| :-------------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName      | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| inferenceEndpointName | string | ✅       | The inference endpoint name.                                                                                                                                                                                                                        |
| page                  | long   | ❌       | The page number.                                                                                                                                                                                                                                    |
| pageSize              | long   | ❌       | The maximum number of items per page.                                                                                                                                                                                                               |

**Return Type**

`InferenceEndpointJobCollection`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var response = await client.InferenceEndpoints.ListInferenceEndpointJobsAsync("acme-corp", "transcribe", 1, 1);

Console.WriteLine(response);
```

## CreateInferenceEndpointJobAsync

Creates a new inference endpoint job.

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs`

**Parameters**

| Name                  | Type                          | Required | Description                                                                                                                                                                                                                                         |
| :-------------------- | :---------------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input                 | InferenceEndpointJobPrototype | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName      | string                        | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| inferenceEndpointName | string                        | ✅       | The inference endpoint name.                                                                                                                                                                                                                        |

**Return Type**

`InferenceEndpointJob`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var input = new InferenceEndpointJobPrototype(new object {}, new object {}, "https://webhook.example.com/events");

var response = await client.InferenceEndpoints.CreateInferenceEndpointJobAsync(input, "acme-corp", "transcribe");

Console.WriteLine(response);
```

## GetInferenceEndpointJobAsync

Gets an inference endpoint job.

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs/{inference_endpoint_job_id}`

**Parameters**

| Name                   | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName       | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| inferenceEndpointName  | string | ✅       | The inference endpoint name.                                                                                                                                                                                                                        |
| inferenceEndpointJobId | string | ✅       | The inference endpoint job identifier.                                                                                                                                                                                                              |

**Return Type**

`InferenceEndpointJob`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var response = await client.InferenceEndpoints.GetInferenceEndpointJobAsync("acme-corp", "transcribe", "2fc459a1-1c09-4a34-ade7-54d03fc51d6a");

Console.WriteLine(response);
```

## DeleteInferenceEndpointJobAsync

Cancels an inference endpoint job.

- HTTP Method: `DELETE`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs/{inference_endpoint_job_id}`

**Parameters**

| Name                   | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName       | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| inferenceEndpointName  | string | ✅       | The inference endpoint name.                                                                                                                                                                                                                        |
| inferenceEndpointJobId | string | ✅       | The inference endpoint job identifier.                                                                                                                                                                                                              |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

await client.InferenceEndpoints.DeleteInferenceEndpointJobAsync("acme-corp", "transcribe", "2fc459a1-1c09-4a34-ade7-54d03fc51d6a");
```
