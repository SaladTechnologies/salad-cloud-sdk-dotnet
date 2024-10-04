```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.Queues.ListQueuesAsync("xtp82b9jzwqov1insghigvfq0donadhrrdqx-2redu46g7e", "xk27gbnpmwk5xor49bk4ujk7");

Console.WriteLine(response);

```
