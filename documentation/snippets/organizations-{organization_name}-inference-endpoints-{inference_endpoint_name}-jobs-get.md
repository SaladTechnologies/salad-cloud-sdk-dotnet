```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointJobsAsync("bzx0y-i4o1cvulgdrx", "minim", 82661968, 27);

Console.WriteLine(response);

```
