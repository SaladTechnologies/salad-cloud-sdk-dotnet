```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new CreateInferenceEndpointJob(new object {});

var response = await client.InferenceEndpoints.CreateInferenceEndpointJobAsync(input, "yg0u13rmnwb7eyumc25lm4prwopvwr-1961f", "consectetur occaecat");

Console.WriteLine(response);

```
