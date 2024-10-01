```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.OrganizationData.ListGpuClassesAsync("w9qttkrqdm5b9xdre4met9ioqxf-a3suyfz4tkhle7s9-vpaj7uvpj");

Console.WriteLine(response);

```
