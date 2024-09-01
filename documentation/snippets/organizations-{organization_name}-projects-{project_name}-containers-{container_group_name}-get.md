```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.GetContainerGroupAsync("zt-dvmb-gmo5a", "enqsq6na2w8d2wlvk-85d3jxhjhj", "fcixv6oyiqlk");

Console.WriteLine(response);

```
