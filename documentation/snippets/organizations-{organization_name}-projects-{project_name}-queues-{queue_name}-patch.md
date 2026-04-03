```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var input = new QueuePatch("description", "hB13");

var response = await client.Queues.UpdateQueueAsync(input, "acme-corp", "dev-env", "fifo-queue");

Console.WriteLine(response);

```
