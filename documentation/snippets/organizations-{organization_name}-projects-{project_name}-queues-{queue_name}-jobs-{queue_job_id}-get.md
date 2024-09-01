```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Queues.GetQueueJobAsync("erx15rey11qozndq25fyep9cx1pky-znnuxifqcep9-zc", "x9-4z-1rr438ze1lo349hdscooit-lme54jb98rdf4itla-wc6aace", "e-tvw-8ybw4mj2a", "queue_job_id");

Console.WriteLine(response);

```
