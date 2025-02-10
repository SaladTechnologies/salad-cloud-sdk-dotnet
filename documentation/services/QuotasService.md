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

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |

**Return Type**

`Quotas`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.Quotas.GetQuotasAsync("acme-corp");

Console.WriteLine(response);
```
