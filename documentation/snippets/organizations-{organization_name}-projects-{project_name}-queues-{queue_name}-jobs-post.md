```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var input = new CreateQueueJob(new object {}, new object {}, "webhook");

var response = await client.Queues.CreateQueueJobAsync(input, "fq0wo6novfjdzwlrie4vz30ajqzk-v6-gctcty9mhydvsq3", "mifj6w-lqsfbkn7h5yqw7l6vm-idada-k-zkc6zg", "lwd1wwfrdxt8y8y8pp161yh3");

Console.WriteLine(response);

```
