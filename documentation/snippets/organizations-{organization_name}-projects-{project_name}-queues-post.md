```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new CreateQueue("ho4d79h7bg0vpngqc8hz5pxjwi");

var response = await client.Queues.CreateQueueAsync(input, "xtp82b9jzwqov1insghigvfq0donadhrrdqx-2redu46g7e", "xk27gbnpmwk5xor49bk4ujk7");

Console.WriteLine(response);

```
