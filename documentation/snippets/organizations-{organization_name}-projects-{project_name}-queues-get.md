```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.Queues.ListQueuesAsync("z8lshc09tfagbfsl8ku-8hu25hwiw5a6dobimir3lfppusjbs", "ohun5ki");

Console.WriteLine(response);

```
