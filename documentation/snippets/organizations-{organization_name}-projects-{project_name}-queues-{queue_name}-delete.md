```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

await client.Queues.DeleteQueueAsync("acme-corp", "dev-env", "fifo-queue");


```
