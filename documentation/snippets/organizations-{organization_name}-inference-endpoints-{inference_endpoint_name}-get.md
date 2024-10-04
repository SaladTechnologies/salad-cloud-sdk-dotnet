```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointAsync("u5ke3wy-5gl1809s8so", "et tempor sint");

Console.WriteLine(response);

```
