```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.WorkloadErrors.GetWorkloadErrorsAsync("qfwe5z1upoqh1awxcmapgsvq9eebxzec9hr", "tk2a9u31toisb02jwlabid0deccukxfa6ddqo5l6uxg3fza3njnv6u8bd9gdex", "uip6z5d7ac-odjxsb15o66m9t");

Console.WriteLine(response);

```
