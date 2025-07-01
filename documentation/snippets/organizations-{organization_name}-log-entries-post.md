```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var input = new LogEntryQuery("end_time", "query", "start_time", 1, LogEntryQuerySortOrder.Desc);

var response = await client.Logs.QueryLogEntriesAsync(input, "acme-corp");

Console.WriteLine(response);

```
