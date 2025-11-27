# LogsService

A list of all methods in the `LogsService` service. Click on the method name to view detailed information about that method.

| Methods                                       | Description                                                                                                               |
| :-------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------ |
| [QueryLogEntriesAsync](#querylogentriesasync) | Retrieve a collection of _log entries_ for the _organization_ identified by `{organization_name}` matching the log query. |

## QueryLogEntriesAsync

Retrieve a collection of _log entries_ for the _organization_ identified by `{organization_name}` matching the log query.

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/log-entries`

**Parameters**

| Name             | Type          | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :------------ | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| input            | LogEntryQuery | ✅       | The request body.                                                                                                                                                                                                                                   |
| organizationName | string        | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |

**Return Type**

`LogEntryCollection`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var input = new LogEntryQuery("end_time", "query", "start_time", 1, LogEntryQuerySortOrder.Desc);

var response = await client.Logs.QueryLogEntriesAsync(input, "acme-corp");

Console.WriteLine(response);
```
