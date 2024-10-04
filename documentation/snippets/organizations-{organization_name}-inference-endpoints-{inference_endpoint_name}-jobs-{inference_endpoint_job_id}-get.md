```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointJobAsync("kdhvnhwadaqzuh18", "eiusmod dolore do", "inference_endpoint_job_id");

Console.WriteLine(response);

```
