```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new CreateInferenceEndpointJob(new object {});

var response = await client.InferenceEndpoints.CreateInferenceEndpointJobAsync(input, "trzfoq1p77wk9jgwxjp56dzbnwtbgowklqt1wsbe00", "ut officia ut");

Console.WriteLine(response);

```
