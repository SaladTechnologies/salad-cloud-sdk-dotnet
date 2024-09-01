```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.ListInferenceEndpointsAsync("wg1umdxtc9fte8osib-e-5ux2vsmrhjjt13u7q3pryxxnm", 756148233, 66);

Console.WriteLine(response);

```
