```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointJobAsync("b7tj9", "sed eu labore", "inference_endpoint_job_id");

Console.WriteLine(response);

```
