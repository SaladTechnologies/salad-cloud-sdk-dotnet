```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var input = new InferenceEndpointJobPrototype(new object {}, new object {}, "https://webhook.example.com/events");

var response = await client.InferenceEndpoints.CreateInferenceEndpointJobAsync(input, "acme-corp", "transcribe");

Console.WriteLine(response);

```
