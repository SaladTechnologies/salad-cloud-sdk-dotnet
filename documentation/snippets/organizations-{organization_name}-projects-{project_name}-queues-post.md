```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new CreateQueue("ykm2ls08p3lv");

var response = await client.Queues.CreateQueueAsync(input, "lwt38wqx9ycbbwq7cz7enua", "i5ohrcyvt0ap8jxyjtw5spbfh7ukelysoi13iija9co");

Console.WriteLine(response);

```
