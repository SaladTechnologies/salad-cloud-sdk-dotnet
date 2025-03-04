```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.StartContainerGroupAsync("acme-corp", "dev-env", "cuwm1y388-m7ehzirdxyvm-4yjt2qfdlzsuvite9");


```
