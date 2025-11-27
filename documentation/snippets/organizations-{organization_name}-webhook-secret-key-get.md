```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var response = await client.WebhookSecretKey.GetWebhookSecretKeyAsync("acme-corp");

Console.WriteLine(response);

```
