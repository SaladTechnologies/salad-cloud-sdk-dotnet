```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var input = new QueuePrototype("name", "AV3ysQq", "description");

var response = await client.Queues.CreateQueueAsync(input, "acme-corp", "dev-env");

Console.WriteLine(response);

```
