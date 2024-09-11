```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.Queues.GetQueueAsync("g1bq27ohe5dpzbgsk8gvpuhecson4k2eclxss3", "wtxd1j0ixuhfk-hdff3n3-hbtsigyh53bt0g4gjh8mcz4", "bnkfiyt3k5ke3wy-5gl1809r");

Console.WriteLine(response);

```
