```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

await client.Queues.DeleteQueueJobAsync("zm-jv", "tq26", "je5dpzbgsk8gvp", "queue_job_id");


```
