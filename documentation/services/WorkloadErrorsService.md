# WorkloadErrorsService

A list of all methods in the `WorkloadErrorsService` service. Click on the method name to view detailed information about that method.

| Methods                                           | Description              |
| :------------------------------------------------ | :----------------------- |
| [GetWorkloadErrorsAsync](#getworkloaderrorsasync) | Gets the workload errors |

## GetWorkloadErrorsAsync

Gets the workload errors

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/projects/{project_name}/containers/{container_group_name}/errors`

**Parameters**

| Name               | Type   | Required | Description                                                                                                                                                                                                                                         |
| :----------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName   | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |
| projectName        | string | ✅       | Your project name. This represents a collection of related SaladCloud resources. The project must be created before using the API.                                                                                                                  |
| containerGroupName | string | ✅       | The unique container group name                                                                                                                                                                                                                     |

**Return Type**

`WorkloadErrorList`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.WorkloadErrors.GetWorkloadErrorsAsync("kr8pje-v4-ccp8q-329szw31h4fee237cnffybnugpd7nbngr", "vjne2vq5j0d2m4f21ex5ozb1-4j-you0d7uftlpfgcaqa-2oc58y844mz", "jpqhlkkgd");

Console.WriteLine(response);
```
