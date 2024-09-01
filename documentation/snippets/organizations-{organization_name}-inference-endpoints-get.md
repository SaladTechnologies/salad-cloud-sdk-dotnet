```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.ListInferenceEndpointsAsync("sqctlusaj22ygymnjifxur", 585200996, 35);

Console.WriteLine(response);

```
