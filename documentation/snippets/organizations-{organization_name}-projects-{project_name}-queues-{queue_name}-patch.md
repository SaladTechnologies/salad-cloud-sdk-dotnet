```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var input = new UpdateQueue("6XVt W", "description");

var response = await client.Queues.UpdateQueueAsync(input, "vcald25asb53i96upv27f-nkhe1", "j6cwfayvsnaqsjq73vtxobiq9pxtqhnf3s0hg9gm", "vt");

Console.WriteLine(response);

```
