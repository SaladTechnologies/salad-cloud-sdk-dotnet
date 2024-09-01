```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.GetContainerGroupInstanceAsync("b0up7kyr7vabeivb96iwcvlvvm1n", "ngljb", "xtp82b9jzwqov1insghigvfq0donadhrrdqx-2redu46g7e", "container_group_instance_id");

Console.WriteLine(response);

```
