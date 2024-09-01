```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.WorkloadErrors.GetWorkloadErrorsAsync("cg3m2ys7p7s0l7bztd09ndj7juif71slwjakka", "rcn12djtrq4osvz", "ha1vqw6i748x874akg4f74ap-5lo17i");

Console.WriteLine(response);

```
