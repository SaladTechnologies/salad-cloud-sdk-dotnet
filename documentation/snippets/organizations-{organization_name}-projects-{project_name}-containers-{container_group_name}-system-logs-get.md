```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var response = await client.SystemLogs.GetSystemLogsAsync("acme-corp", "dev-env", "mandlebrot");

Console.WriteLine(response);

```
