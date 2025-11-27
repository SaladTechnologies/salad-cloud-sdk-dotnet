```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.RecreateContainerGroupInstanceAsync("acme-corp", "dev-env", "mandlebrot", "db3a4591-efc3-46c0-b06a-3d820c0ec100");


```
