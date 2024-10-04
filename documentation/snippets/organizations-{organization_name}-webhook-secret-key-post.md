```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.WebhookSecretKey.UpdateWebhookSecretKeyAsync("mouv4w914sp420zyiuo43jexocjzq6rnxf04dqmccakipx9g3a72svbj");

Console.WriteLine(response);

```
