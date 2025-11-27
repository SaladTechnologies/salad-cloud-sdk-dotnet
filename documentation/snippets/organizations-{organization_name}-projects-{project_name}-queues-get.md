```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var response = await client.Queues.ListQueuesAsync("acme-corp", "dev-env");

Console.WriteLine(response);

```
