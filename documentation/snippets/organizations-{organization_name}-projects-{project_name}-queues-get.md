```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Queues.ListQueuesAsync("lwt38wqx9ycbbwq7cz7enua", "i5ohrcyvt0ap8jxyjtw5spbfh7ukelysoi13iija9co");

Console.WriteLine(response);

```
