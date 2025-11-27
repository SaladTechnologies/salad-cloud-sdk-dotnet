```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.DeleteContainerGroupAsync("acme-corp", "dev-env", "mandlebrot");


```
