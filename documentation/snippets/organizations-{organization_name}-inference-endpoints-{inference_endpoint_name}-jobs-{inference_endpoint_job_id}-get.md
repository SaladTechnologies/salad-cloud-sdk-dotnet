```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.InferenceEndpoints.GetInferenceEndpointJobAsync("g0i5w146fxc3k", "inference_endpoint_name", "inference_endpoint_job_id");

Console.WriteLine(response);

```
