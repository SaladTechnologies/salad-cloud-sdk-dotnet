```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.Quotas.GetQuotasAsync("oecson4k2eclxr");

Console.WriteLine(response);

```
