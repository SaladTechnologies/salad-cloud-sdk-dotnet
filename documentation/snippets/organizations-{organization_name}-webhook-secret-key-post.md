```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.WebhookSecretKey.UpdateWebhookSecretKeyAsync("dyxdaqq1t3iwwpawdlk-78rt9bh26smkuf3v0nd2ropp");

Console.WriteLine(response);

```
