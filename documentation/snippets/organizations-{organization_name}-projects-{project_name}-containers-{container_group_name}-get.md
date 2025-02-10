```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.ContainerGroups.GetContainerGroupAsync("acme-corp", "dev-env", "dtediyiq06xdhi419x1-qxggstra232ermkpky80pttw977-5xv6fsvjlccb2");

Console.WriteLine(response);

```
