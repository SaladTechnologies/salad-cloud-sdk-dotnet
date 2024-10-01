```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new CreateInferenceEndpointJob(new object {});

var response = await client.InferenceEndpoints.CreateInferenceEndpointJobAsync(input, "bzx0y-i4o1cvulgdrx", "minim");

Console.WriteLine(response);

```
