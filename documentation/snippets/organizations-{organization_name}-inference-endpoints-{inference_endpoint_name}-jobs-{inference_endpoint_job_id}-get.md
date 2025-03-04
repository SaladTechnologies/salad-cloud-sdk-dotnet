```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.InferenceEndpoints.GetInferenceEndpointJobAsync("acme-corp", "transcribe", "2fc459a1-1c09-4a34-ade7-54d03fc51d6a");

Console.WriteLine(response);

```
