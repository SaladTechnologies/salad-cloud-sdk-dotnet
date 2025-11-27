```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var response = await client.OrganizationData.ListGpuClassesAsync("acme-corp");

Console.WriteLine(response);

```
