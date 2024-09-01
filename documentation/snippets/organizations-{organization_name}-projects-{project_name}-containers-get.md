```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.ListContainerGroupsAsync("ep7fgeqvy6vfd66h1ewe-69h", "dpdhw0h4i3hwpdzw9");

Console.WriteLine(response);

```
