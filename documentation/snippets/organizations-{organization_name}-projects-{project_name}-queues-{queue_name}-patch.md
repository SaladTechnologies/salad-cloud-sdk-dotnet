```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var input = new QueuePatch("N5EcnfeqKM", "description");

var response = await client.Queues.UpdateQueueAsync(input, "acme-corp", "dev-env", "fifo-queue");

Console.WriteLine(response);

```
