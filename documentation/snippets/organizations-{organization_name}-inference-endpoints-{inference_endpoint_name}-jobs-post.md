```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new CreateInferenceEndpointJob(new object {});

var response = await client.InferenceEndpoints.CreateInferenceEndpointJobAsync(input, "et0wus4xea-xt7p0xv", "minim Ut s");

Console.WriteLine(response);

```
