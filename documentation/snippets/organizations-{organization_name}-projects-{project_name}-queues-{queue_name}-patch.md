```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new UpdateQueue();

var response = await client.Queues.UpdateQueueAsync(input, "g1bq27ohe5dpzbgsk8gvpuhecson4k2eclxss3", "wtxd1j0ixuhfk-hdff3n3-hbtsigyh53bt0g4gjh8mcz4", "bnkfiyt3k5ke3wy-5gl1809r");

Console.WriteLine(response);

```
