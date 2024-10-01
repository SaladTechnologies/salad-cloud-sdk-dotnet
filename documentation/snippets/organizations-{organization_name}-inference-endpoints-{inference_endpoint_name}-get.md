```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointAsync("zux2vsmrhjjt13u7q3pryxxnnnyigut20zp1dyfm2yp4-lxa27tl0e", "qui adipisicing");

Console.WriteLine(response);

```
