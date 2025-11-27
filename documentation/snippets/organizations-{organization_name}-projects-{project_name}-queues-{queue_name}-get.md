```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var response = await client.Queues.GetQueueAsync("acme-corp", "dev-env", "fifo-queue");

Console.WriteLine(response);

```
