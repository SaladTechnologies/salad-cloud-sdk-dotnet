```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new CreateQueueJob(new object {});

var response = await client.Queues.CreateQueueJobAsync(input, "jb7eyumc25lm4prwopvwr-1961g-m85nbqda3ufs", "sn780t45z2tw4xt1b86w0clx6vkq-3", "sx811v32aty9s-ghx1hm2nw1mhgooidhvnhwadaqzuh19krhv62or5c");

Console.WriteLine(response);

```
