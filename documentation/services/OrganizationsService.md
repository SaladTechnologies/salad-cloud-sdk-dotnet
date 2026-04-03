# OrganizationsService

A list of all methods in the `OrganizationsService` service. Click on the method name to view detailed information about that method.

| Methods                                             | Description                                          |
| :-------------------------------------------------- | :--------------------------------------------------- |
| [GetCpuAvailabilityAsync](#getcpuavailabilityasync) | Gets the CPU availability for the given organization |
| [GetGpuAvailabilityAsync](#getgpuavailabilityasync) | Gets the GPU availability for the given organization |

## GetCpuAvailabilityAsync

Gets the CPU availability for the given organization

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/availability/sce-cpu-availability`

**Parameters**

| Name             | Type                     | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input            | CpuAvailabilityPrototype | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName | string                   | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |

**Return Type**

`CpuAvailability`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var countryCodes = new List<CountryCode>() { CountryCode.Af };
var input = new CpuAvailabilityPrototype(countryCodes, 4, 8192, 1000000000);

var response = await client.Organizations.GetCpuAvailabilityAsync(input, "acme-corp");

Console.WriteLine(response);
```

## GetGpuAvailabilityAsync

Gets the GPU availability for the given organization

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/availability/sce-gpu-availability`

**Parameters**

| Name             | Type                     | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input            | GpuAvailabilityPrototype | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName | string                   | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |

**Return Type**

`GpuAvailability`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var gpuClasses = new List<string>() { "gpu_classes" };
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var input = new GpuAvailabilityPrototype(gpuClasses, countryCodes, 4, 8192, 1000000000);

var response = await client.Organizations.GetGpuAvailabilityAsync(input, "acme-corp");

Console.WriteLine(response);
```
