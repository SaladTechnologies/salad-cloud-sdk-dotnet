# QuotasService

A list of all methods in the `QuotasService` service. Click on the method name to view detailed information about that method.

| Methods                           | Description                  |
| :-------------------------------- | :--------------------------- |
| [GetQuotasAsync](#getquotasasync) | Gets the organization quotas |

## GetQuotasAsync

Gets the organization quotas

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/quotas`

**Parameters**

| Name             | Type   | Required | Description                  |
| :--------------- | :----- | :------- | :--------------------------- |
| organizationName | string | ✅       | The unique organization name |

**Return Type**

`Quotas`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Quotas.GetQuotasAsync("o110sou");

Console.WriteLine(response);
```
