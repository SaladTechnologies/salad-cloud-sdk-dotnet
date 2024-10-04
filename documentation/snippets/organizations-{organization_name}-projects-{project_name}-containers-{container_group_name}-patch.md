```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new UpdateContainerGroup();

var response = await client.ContainerGroups.UpdateContainerGroupAsync(input, "oji7lyvxb3ca5hc", "olb1uzytbhhukf1u0-ahl0b9oqfjj", "s7z7dvdopv2czgde1zrufxgiv5tp-j");

Console.WriteLine(response);

```
