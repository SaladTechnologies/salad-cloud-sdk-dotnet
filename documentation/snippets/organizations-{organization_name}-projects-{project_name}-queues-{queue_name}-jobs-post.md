```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new CreateQueueJob(new object {});

var response = await client.Queues.CreateQueueJobAsync(input, "qiqiazzthr12lsqkk1iq35-ix3pzbff9-f8x8ls569n71", "ht3-tiei7j9ye5yzdixjzbx5ywjbd", "xp465rhqkyqstwpk8kd3jy5kakai4lollggq7i7xz97");

Console.WriteLine(response);

```
