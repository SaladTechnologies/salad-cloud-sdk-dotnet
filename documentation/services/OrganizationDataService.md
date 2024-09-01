# OrganizationDataService

A list of all methods in the `OrganizationDataService` service. Click on the method name to view detailed information about that method.

| Methods                                     | Description          |
| :------------------------------------------ | :------------------- |
| [ListGpuClassesAsync](#listgpuclassesasync) | List the GPU Classes |

## ListGpuClassesAsync

List the GPU Classes

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/gpu-classes`

**Parameters**

| Name             | Type   | Required | Description                  |
| :--------------- | :----- | :------- | :--------------------------- |
| organizationName | string | ✅       | The unique organization name |

**Return Type**

`GpuClassesList`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.OrganizationData.ListGpuClassesAsync("ksb7ikadj659qttkrqdm5b9xdre4met9iop");

Console.WriteLine(response);
```
