```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.GetInferenceEndpointJobAsync("v0jo001xz6w2uhgmhtgvpqzhztmaqawqn92-rig0bznv-21cb7tj-hp2ecbvldq", "elit sint", "inference_endpoint_job_id");

Console.WriteLine(response);

```
