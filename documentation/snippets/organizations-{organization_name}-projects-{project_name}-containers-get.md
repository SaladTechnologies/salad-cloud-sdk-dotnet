```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.ListContainerGroupsAsync("v50imwzgi4em4q035", "m6yw3-xm60cb7tiev8rketqiiwjepibzf2ust1cvjx8oua8mepeueo5-1");

Console.WriteLine(response);

```
