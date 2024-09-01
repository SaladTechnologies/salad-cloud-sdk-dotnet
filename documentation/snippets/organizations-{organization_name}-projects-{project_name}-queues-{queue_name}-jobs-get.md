```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Queues.ListQueueJobsAsync("jb7eyumc25lm4prwopvwr-1961g-m85nbqda3ufs", "sn780t45z2tw4xt1b86w0clx6vkq-3", "sx811v32aty9s-ghx1hm2nw1mhgooidhvnhwadaqzuh19krhv62or5c", 2110014563, 23);

Console.WriteLine(response);

```
