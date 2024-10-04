```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointJobsAsync("yg0u13rmnwb7eyumc25lm4prwopvwr-1961f", "consectetur occaecat", 355955712, 39);

Console.WriteLine(response);

```
