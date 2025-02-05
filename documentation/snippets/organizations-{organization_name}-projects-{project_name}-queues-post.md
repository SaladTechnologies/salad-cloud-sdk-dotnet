```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var input = new CreateQueue("name", "xN", "description");

var response = await client.Queues.CreateQueueAsync(input, "z8lshc09tfagbfsl8ku-8hu25hwiw5a6dobimir3lfppusjbs", "ohun5ki");

Console.WriteLine(response);

```
