# InferenceEndpointsService

A list of all methods in the `InferenceEndpointsService` service. Click on the method name to view detailed information about that method.

| Methods                                                             | Description                                    |
| :------------------------------------------------------------------ | :--------------------------------------------- |
| [ListInferenceEndpointsAsync](#listinferenceendpointsasync)         | Gets the list of inference endpoints           |
| [GetInferenceEndpointAsync](#getinferenceendpointasync)             | Gets an inference endpoint                     |
| [GetInferenceEndpointJobsAsync](#getinferenceendpointjobsasync)     | Retrieves a list of an inference endpoint jobs |
| [CreateInferenceEndpointJobAsync](#createinferenceendpointjobasync) | Creates a new job                              |
| [GetInferenceEndpointJobAsync](#getinferenceendpointjobasync)       | Retrieves a job in an inference endpoint       |
| [DeleteInferenceEndpointJobAsync](#deleteinferenceendpointjobasync) | Deletes an inference endpoint job              |

## ListInferenceEndpointsAsync

Gets the list of inference endpoints

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/inference-endpoints`

**Parameters**

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| page             | long   | ❌       | The page number                                                                                                                                                                                                                                     |
| pageSize         | long   | ❌       | The number of items per page                                                                                                                                                                                                                        |

**Return Type**

`InferenceEndpointsList`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.ListInferenceEndpointsAsync("l50g1umdxtc9fte7", 832002798, 51);

Console.WriteLine(response);
```

## GetInferenceEndpointAsync

Gets an inference endpoint

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}`

**Parameters**

| Name                  | Type   | Required | Description                                                                                                                                                                                                                                         |
| :-------------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName      | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| inferenceEndpointName | string | ✅       | The unique inference endpoint name                                                                                                                                                                                                                  |

**Return Type**

`InferenceEndpoint`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointAsync("zux2vsmrhjjt13u7q3pryxxnnnyigut20zp1dyfm2yp4-lxa27tl0e", "qui adipisicing");

Console.WriteLine(response);
```

## GetInferenceEndpointJobsAsync

Retrieves a list of an inference endpoint jobs

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs`

**Parameters**

| Name                  | Type   | Required | Description                                                                                                                                                                                                                                         |
| :-------------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName      | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| inferenceEndpointName | string | ✅       | The unique inference endpoint name                                                                                                                                                                                                                  |
| page                  | long   | ❌       | The page number                                                                                                                                                                                                                                     |
| pageSize              | long   | ❌       | The number of items per page                                                                                                                                                                                                                        |

**Return Type**

`InferenceEndpointJobList`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointJobsAsync("bzx0y-i4o1cvulgdrx", "minim", 82661968, 27);

Console.WriteLine(response);
```

## CreateInferenceEndpointJobAsync

Creates a new job

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs`

**Parameters**

| Name                  | Type                       | Required | Description                                                                                                                                                                                                                                         |
| :-------------------- | :------------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input                 | CreateInferenceEndpointJob | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName      | string                     | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| inferenceEndpointName | string                     | ✅       | The unique inference endpoint name                                                                                                                                                                                                                  |

**Return Type**

`InferenceEndpointJob`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new CreateInferenceEndpointJob(new object {});

var response = await client.InferenceEndpoints.CreateInferenceEndpointJobAsync(input, "bzx0y-i4o1cvulgdrx", "minim");

Console.WriteLine(response);
```

## GetInferenceEndpointJobAsync

Retrieves a job in an inference endpoint

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs/{inference_endpoint_job_id}`

**Parameters**

| Name                   | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName       | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| inferenceEndpointName  | string | ✅       | The unique inference endpoint name                                                                                                                                                                                                                  |
| inferenceEndpointJobId | string | ✅       | The unique job id                                                                                                                                                                                                                                   |

**Return Type**

`InferenceEndpointJob`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointJobAsync("v0jo001xz6w2uhgmhtgvpqzhztmaqawqn92-rig0bznv-21cb7tj-hp2ecbvldq", "elit sint", "inference_endpoint_job_id");

Console.WriteLine(response);
```

## DeleteInferenceEndpointJobAsync

Deletes an inference endpoint job

- HTTP Method: `DELETE`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs/{inference_endpoint_job_id}`

**Parameters**

| Name                   | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName       | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| inferenceEndpointName  | string | ✅       | The unique inference endpoint name                                                                                                                                                                                                                  |
| inferenceEndpointJobId | string | ✅       | The unique job id                                                                                                                                                                                                                                   |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

await client.InferenceEndpoints.DeleteInferenceEndpointJobAsync("v0jo001xz6w2uhgmhtgvpqzhztmaqawqn92-rig0bznv-21cb7tj-hp2ecbvldq", "elit sint", "inference_endpoint_job_id");
```
