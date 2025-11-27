```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var input = new QueueJobPrototype(new object {}, new object {}, "webhook");

var response = await client.Queues.CreateQueueJobAsync(input, "acme-corp", "dev-env", "fifo-queue");

Console.WriteLine(response);

```
