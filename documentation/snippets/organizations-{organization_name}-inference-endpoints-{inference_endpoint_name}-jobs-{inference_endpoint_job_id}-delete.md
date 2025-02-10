```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.InferenceEndpoints.DeleteInferenceEndpointJobAsync("acme-corp", "inference_endpoint_name", "inference_endpoint_job_id");


```
