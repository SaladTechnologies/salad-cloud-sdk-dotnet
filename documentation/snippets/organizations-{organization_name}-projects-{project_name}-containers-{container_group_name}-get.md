```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.GetContainerGroupAsync("oji7lyvxb3ca5hc", "olb1uzytbhhukf1u0-ahl0b9oqfjj", "s7z7dvdopv2czgde1zrufxgiv5tp-j");

Console.WriteLine(response);

```
