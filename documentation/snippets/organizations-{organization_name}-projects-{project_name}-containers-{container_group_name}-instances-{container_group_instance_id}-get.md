```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.GetContainerGroupInstanceAsync("cce0i3", "bb53k", "vtsp-47yvqix7", "container_group_instance_id");

Console.WriteLine(response);

```
