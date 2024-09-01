```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Queues.ListQueueJobsAsync("qiqiazzthr12lsqkk1iq35-ix3pzbff9-f8x8ls569n71", "ht3-tiei7j9ye5yzdixjzbx5ywjbd", "xp465rhqkyqstwpk8kd3jy5kakai4lollggq7i7xz97", 1955049824, 95);

Console.WriteLine(response);

```
