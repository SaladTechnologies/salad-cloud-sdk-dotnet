```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.ListInferenceEndpointsAsync("l50g1umdxtc9fte7", 832002798, 51);

Console.WriteLine(response);

```
