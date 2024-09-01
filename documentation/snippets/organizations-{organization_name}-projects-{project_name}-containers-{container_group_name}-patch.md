```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new UpdateContainerGroup();

var response = await client.ContainerGroups.UpdateContainerGroupAsync(input, "zt-dvmb-gmo5a", "enqsq6na2w8d2wlvk-85d3jxhjhj", "fcixv6oyiqlk");

Console.WriteLine(response);

```
