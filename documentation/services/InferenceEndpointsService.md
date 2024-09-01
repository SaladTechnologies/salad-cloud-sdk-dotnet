# InferenceEndpointsService

A list of all methods in the `InferenceEndpointsService` service. Click on the method name to view detailed information about that method.

| Methods                                                             | Description                                    |
| :------------------------------------------------------------------ | :--------------------------------------------- |
| [ListInferenceEndpointsAsync](#listinferenceendpointsasync)         | Gets the list of all inference endpoints       |
| [GetInferenceEndpointAsync](#getinferenceendpointasync)             | Gets an inference endpoint                     |
| [GetInferenceEndpointJobsAsync](#getinferenceendpointjobsasync)     | Retrieves a list of an inference endpoint jobs |
| [CreateInferenceEndpointJobAsync](#createinferenceendpointjobasync) | Creates a new job                              |
| [GetInferenceEndpointJobAsync](#getinferenceendpointjobasync)       | Retrieves a job in an inference endpoint       |
| [DeleteInferenceEndpointJobAsync](#deleteinferenceendpointjobasync) | Deletes an inference endpoint job              |

## ListInferenceEndpointsAsync

Gets the list of all inference endpoints

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/inference-endpoints`

**Parameters**

| Name             | Type   | Required | Description                  |
| :--------------- | :----- | :------- | :--------------------------- |
| organizationName | string | ✅       | The unique organization name |
| page             | long   | ❌       | The page number              |
| pageSize         | long   | ❌       | The number of items per page |

**Return Type**

`InferenceEndpointsList`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.ListInferenceEndpointsAsync("wg1umdxtc9fte8osib-e-5ux2vsmrhjjt13u7q3pryxxnm", 756148233, 66);

Console.WriteLine(response);
```

## GetInferenceEndpointAsync

Gets an inference endpoint

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}`

**Parameters**

| Name                  | Type   | Required | Description                        |
| :-------------------- | :----- | :------- | :--------------------------------- |
| organizationName      | string | ✅       | The unique organization name       |
| inferenceEndpointName | string | ✅       | The unique inference endpoint name |

**Return Type**

`InferenceEndpoint`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointAsync("uzp1dyfm2yp4-lxa27tl0fwms3fu3myo74a99jr6ouv4w8", "aute Ut reprehenderit occaecat sed");

Console.WriteLine(response);
```

## GetInferenceEndpointJobsAsync

Retrieves a list of an inference endpoint jobs

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs`

**Parameters**

| Name                  | Type   | Required | Description                        |
| :-------------------- | :----- | :------- | :--------------------------------- |
| organizationName      | string | ✅       | The unique organization name       |
| inferenceEndpointName | string | ✅       | The unique inference endpoint name |
| page                  | long   | ❌       | The page number                    |
| pageSize              | long   | ❌       | The number of items per page       |

**Return Type**

`InferenceEndpointJobList`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointJobsAsync("trzfoq1p77wk9jgwxjp56dzbnwtbgowklqt1wsbe00", "ut officia ut", 1653138765, 76);

Console.WriteLine(response);
```

## CreateInferenceEndpointJobAsync

Creates a new job

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs`

**Parameters**

| Name                  | Type                       | Required | Description                        |
| :-------------------- | :------------------------- | :------- | :--------------------------------- |
| input                 | CreateInferenceEndpointJob | ✅       | The request body.                  |
| organizationName      | string                     | ✅       | The unique organization name       |
| inferenceEndpointName | string                     | ✅       | The unique inference endpoint name |

**Return Type**

`InferenceEndpointJob`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new CreateInferenceEndpointJob(new object {});

var response = await client.InferenceEndpoints.CreateInferenceEndpointJobAsync(input, "trzfoq1p77wk9jgwxjp56dzbnwtbgowklqt1wsbe00", "ut officia ut");

Console.WriteLine(response);
```

## GetInferenceEndpointJobAsync

Retrieves a job in an inference endpoint

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs/{inference_endpoint_job_id}`

**Parameters**

| Name                   | Type   | Required | Description                        |
| :--------------------- | :----- | :------- | :--------------------------------- |
| organizationName       | string | ✅       | The unique organization name       |
| inferenceEndpointName  | string | ✅       | The unique inference endpoint name |
| inferenceEndpointJobId | string | ✅       | The unique job id                  |

**Return Type**

`InferenceEndpointJob`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointJobAsync("b7tj9", "sed eu labore", "inference_endpoint_job_id");

Console.WriteLine(response);
```

## DeleteInferenceEndpointJobAsync

Deletes an inference endpoint job

- HTTP Method: `DELETE`
- Endpoint: `/organizations/{organization_name}/inference-endpoints/{inference_endpoint_name}/jobs/{inference_endpoint_job_id}`

**Parameters**

| Name                   | Type   | Required | Description                        |
| :--------------------- | :----- | :------- | :--------------------------------- |
| organizationName       | string | ✅       | The unique organization name       |
| inferenceEndpointName  | string | ✅       | The unique inference endpoint name |
| inferenceEndpointJobId | string | ✅       | The unique job id                  |

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

await client.InferenceEndpoints.DeleteInferenceEndpointJobAsync("b7tj9", "sed eu labore", "inference_endpoint_job_id");
```
