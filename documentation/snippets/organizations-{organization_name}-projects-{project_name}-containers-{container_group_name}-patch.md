```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new UpdateContainerGroup();

var response = await client.ContainerGroups.UpdateContainerGroupAsync(input, "ob3ca5hduqlb1uzytbhhukf1u0-ahl0b9oqfjj0q", "x7dvdopv2czgde1zrufxgiv5tp-kncd4gfzda9ik-lx71", "cif9b1yvozs9trd4v0bll7qwslfehyhnfadnjp2w52gwrm0urjjj5b9hbe2fr6f");

Console.WriteLine(response);

```
