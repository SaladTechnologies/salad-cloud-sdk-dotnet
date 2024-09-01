```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointAsync("rvbmdh-8zxih", "id nulla");

Console.WriteLine(response);

```
