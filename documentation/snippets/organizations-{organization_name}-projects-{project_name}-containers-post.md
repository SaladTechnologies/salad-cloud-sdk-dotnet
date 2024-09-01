```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var resources = new ContainerResourceRequirements(10, 17858);
var container = new CreateContainer("velit qui cillum veniam ullamco", resources);
var input = new CreateContainerGroup("oh2mpxyfojt-6cco", container, false, ContainerRestartPolicy.Always, 225);

var response = await client.ContainerGroups.CreateContainerGroupAsync(input, "v50imwzgi4em4q035", "m6yw3-xm60cb7tiev8rketqiiwjepibzf2ust1cvjx8oua8mepeueo5-1");

Console.WriteLine(response);

```
