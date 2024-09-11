```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.GetContainerGroupAsync("gq7z7dvdopv2czgde1zrufxgiv5tp-kncd4gfzda9ik-lw", "xd-if9b1yvozs9trd4v0bll7qwslfehyhnfadnjp2w52gwrmz", "ojjj5b9hbe2fr6f5t7j1htjaws1zx3r");

Console.WriteLine(response);

```
