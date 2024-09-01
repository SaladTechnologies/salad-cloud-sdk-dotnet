```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var resources = new ContainerResourceRequirements(6, 8938);
var container = new CreateContainer("magna laboris exercitation sunt", resources);
var input = new CreateContainerGroup("vgm3", container, false, ContainerRestartPolicy.Always, 21);

var response = await client.ContainerGroups.CreateContainerGroupAsync(input, "ep7fgeqvy6vfd66h1ewe-69h", "dpdhw0h4i3hwpdzw9");

Console.WriteLine(response);

```
