```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.Quotas.GetQuotasAsync("y-7yhh5v70xusg163gdfs9vma6wkyd2rcvosdiwny-k");

Console.WriteLine(response);

```
