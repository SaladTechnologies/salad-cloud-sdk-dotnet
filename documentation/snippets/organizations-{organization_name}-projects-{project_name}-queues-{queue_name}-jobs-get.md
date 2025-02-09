```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.Queues.ListQueueJobsAsync("acme-corp", "dev-env", "fifo-queue", 1675858596, 52);

Console.WriteLine(response);

```
