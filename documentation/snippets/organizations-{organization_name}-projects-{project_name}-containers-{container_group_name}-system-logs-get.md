```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.SystemLogs.GetSystemLogsAsync("swsj5dkyyw", "a5xp2xbkltsrb1gyvruaqvvwd5onmy71o9wj-qe9t5ayz4g85", "jm88ew1l7vlqq7ldjxvyv2t81idvvr61j8rx5e7nek5ai");

Console.WriteLine(response);

```
