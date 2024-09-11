```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var resources = new ContainerResourceRequirements(10, 17858);
var container = new CreateContainer("voluptate officia adipisicing", resources);
var input = new CreateContainerGroup("qfojt-6ccoil4t55-ccoyybgw92dermtsdfn3t2xmag", container, false, ContainerRestartPolicy.Always, 114);

var response = await client.ContainerGroups.CreateContainerGroupAsync(input, "v50imwzgi4em4q035", "m6yw3-xm60cb7tiev8rketqiiwjepibzf2ust1cvjx8oua8mepeueo5-1");

Console.WriteLine(response);

```
