```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var response = await client.InferenceEndpoints.ListInferenceEndpointJobsAsync("acme-corp", "transcribe", 1, 1);

Console.WriteLine(response);

```
