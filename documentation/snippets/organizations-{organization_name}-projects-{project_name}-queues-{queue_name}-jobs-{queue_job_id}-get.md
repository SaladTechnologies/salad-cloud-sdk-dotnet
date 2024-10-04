```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.Queues.GetQueueJobAsync("zm-jv", "tq26", "je5dpzbgsk8gvp", "queue_job_id");

Console.WriteLine(response);

```
