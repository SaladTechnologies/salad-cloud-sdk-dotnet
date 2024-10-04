```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.GetContainerGroupInstanceAsync("a09xnu6-fkv3", "ca4ydy-pi16e4ddle58fi8u9w2qgnsgj7cn", "b4p90a72aagy0fz", "container_group_instance_id");

Console.WriteLine(response);

```
