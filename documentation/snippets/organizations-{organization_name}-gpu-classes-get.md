```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.OrganizationData.ListGpuClassesAsync("fux");

Console.WriteLine(response);

```
