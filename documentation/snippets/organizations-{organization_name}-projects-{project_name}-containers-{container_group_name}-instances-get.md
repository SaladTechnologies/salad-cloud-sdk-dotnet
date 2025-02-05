```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.ContainerGroups.ListContainerGroupInstancesAsync("syhixarx9", "n2f3v2k", "mqs513hwceoink7v5jbtans22e-s9a9g");

Console.WriteLine(response);

```
