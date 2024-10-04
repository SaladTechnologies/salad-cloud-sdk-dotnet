```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.Queues.ListQueueJobsAsync("wcaz2jbu5pfmpygxffsf4bh4e6", "dzh9lv6afpamv8cx0x6", "s9f4ikmr0j6c3n18n4djttkqmgzb46dd5wogzrfe2pq12s2", 706148771, 45);

Console.WriteLine(response);

```
