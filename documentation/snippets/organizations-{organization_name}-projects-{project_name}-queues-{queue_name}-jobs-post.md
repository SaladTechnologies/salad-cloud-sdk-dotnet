```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new CreateQueueJob(new object {});

var response = await client.Queues.CreateQueueJobAsync(input, "wcaz2jbu5pfmpygxffsf4bh4e6", "dzh9lv6afpamv8cx0x6", "s9f4ikmr0j6c3n18n4djttkqmgzb46dd5wogzrfe2pq12s2");

Console.WriteLine(response);

```
