```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointJobAsync("wm7sq978nq8j748qskk0hr2eg4sl7t97a39br872", "ullamco", "inference_endpoint_job_id");

Console.WriteLine(response);

```
