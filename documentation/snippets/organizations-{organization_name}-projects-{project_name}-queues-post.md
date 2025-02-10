```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var input = new CreateQueue("name", "ACBtFd", "description");

var response = await client.Queues.CreateQueueAsync(input, "acme-corp", "dev-env");

Console.WriteLine(response);

```
