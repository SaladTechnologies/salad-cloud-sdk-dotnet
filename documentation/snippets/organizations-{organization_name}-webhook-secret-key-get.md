```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.WebhookSecretKey.GetWebhookSecretKeyAsync("ligmbu0fdje049b02qi1m-z0vs1teiglhclcygv1wqqusk00zsx");

Console.WriteLine(response);

```
