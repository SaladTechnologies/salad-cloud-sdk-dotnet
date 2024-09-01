```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.WebhookSecretKey.UpdateWebhookSecretKeyAsync("hn9h7px3wro2wjja0yeu6kcgk0nggtveqmh45ilbsw4b2dcch55e1sj");

Console.WriteLine(response);

```
