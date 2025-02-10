```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.SystemLogs.GetSystemLogsAsync("acme-corp", "dev-env", "a40v4uec9stndv1t4v2c9ytnldjc0jenoa7-st6miphpfp4jw");

Console.WriteLine(response);

```
