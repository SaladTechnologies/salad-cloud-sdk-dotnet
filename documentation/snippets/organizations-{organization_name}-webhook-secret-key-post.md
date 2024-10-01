```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.WebhookSecretKey.UpdateWebhookSecretKeyAsync("wmkuf3v0nd2roppi64zikv73wys88ns81");

Console.WriteLine(response);

```
