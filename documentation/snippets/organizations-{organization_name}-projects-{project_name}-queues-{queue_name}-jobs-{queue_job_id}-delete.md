```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

await client.Queues.DeleteQueueJobAsync("acme-corp", "dev-env", "fifo-queue", "7dcd6922-50e9-4d56-89b5-91cde26f0211");


```
