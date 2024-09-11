```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointAsync("uzp1dyfm2yp4-lxa27tl0fwms3fu3myo74a99jr6ouv4w8", "aute Ut reprehenderit occaecat sed");

Console.WriteLine(response);

```
