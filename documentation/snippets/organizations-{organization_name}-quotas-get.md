```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.Quotas.GetQuotasAsync("o110sou");

Console.WriteLine(response);

```
