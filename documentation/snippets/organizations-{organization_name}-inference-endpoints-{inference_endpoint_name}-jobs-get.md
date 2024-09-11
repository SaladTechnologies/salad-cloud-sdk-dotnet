```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointJobsAsync("trzfoq1p77wk9jgwxjp56dzbnwtbgowklqt1wsbe00", "ut officia ut", 1653138765, 76);

Console.WriteLine(response);

```
