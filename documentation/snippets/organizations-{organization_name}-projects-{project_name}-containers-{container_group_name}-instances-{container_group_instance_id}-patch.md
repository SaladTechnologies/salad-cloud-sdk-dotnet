```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var input = new ContainerGroupInstancePatch(19725);

var response = await client.ContainerGroups.UpdateContainerGroupInstanceAsync(input, "acme-corp", "dev-env", "mandlebrot", "db3a4591-efc3-46c0-b06a-3d820c0ec100");

Console.WriteLine(response);

```
