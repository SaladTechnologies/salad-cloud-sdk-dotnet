```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var input = new InferenceEndpointJobPrototype(new object {}, new object {}, "https://webhook.example.com/events");

var response = await client.InferenceEndpoints.CreateInferenceEndpointJobAsync(input, "acme-corp", "transcribe");

Console.WriteLine(response);

```
