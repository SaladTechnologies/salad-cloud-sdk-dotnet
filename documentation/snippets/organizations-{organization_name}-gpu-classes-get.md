```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.OrganizationData.ListGpuClassesAsync("ksb7ikadj659qttkrqdm5b9xdre4met9iop");

Console.WriteLine(response);

```
