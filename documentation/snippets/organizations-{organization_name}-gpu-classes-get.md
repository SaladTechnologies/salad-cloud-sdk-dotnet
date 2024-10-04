```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.OrganizationData.ListGpuClassesAsync("vsg-okxas9m7y892q4m5rifzmevenpg1vot8xgbal");

Console.WriteLine(response);

```
