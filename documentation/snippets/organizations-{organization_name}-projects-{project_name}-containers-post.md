```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var resources = new ContainerResourceRequirements(10, 35273);
var container = new CreateContainer("reprehenderit", resources);
var input = new CreateContainerGroup("xvih", container, false, ContainerRestartPolicy.Always, 12);

var response = await client.ContainerGroups.CreateContainerGroupAsync(input, "v50imwzgi4em4q035", "m6yw3-xm60cb7tiev8rketqiiwjepibzf2ust1cvjx8oua8mepeueo5-1");

Console.WriteLine(response);

```
