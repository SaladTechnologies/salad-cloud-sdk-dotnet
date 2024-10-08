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

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |

**Return Type**

`GpuClassesList`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.OrganizationData.ListGpuClassesAsync("vsg-okxas9m7y892q4m5rifzmevenpg1vot8xgbal");

Console.WriteLine(response);
```
