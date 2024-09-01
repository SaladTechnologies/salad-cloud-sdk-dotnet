# WebhookSecretKeyService

A list of all methods in the `WebhookSecretKeyService` service. Click on the method name to view detailed information about that method.

| Methods                                                     | Description                    |
| :---------------------------------------------------------- | :----------------------------- |
| [GetWebhookSecretKeyAsync](#getwebhooksecretkeyasync)       | Gets the webhook secret key    |
| [UpdateWebhookSecretKeyAsync](#updatewebhooksecretkeyasync) | Updates the webhook secret key |

## GetWebhookSecretKeyAsync

Gets the webhook secret key

- HTTP Method: `GET`
- Endpoint: `/organizations/{organization_name}/webhook-secret-key`

**Parameters**

| Name             | Type   | Required | Description                  |
| :--------------- | :----- | :------- | :--------------------------- |
| organizationName | string | ✅       | The unique organization name |

**Return Type**

`WebhookSecretKey`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.WebhookSecretKey.GetWebhookSecretKeyAsync("dyxdaqq1t3iwwpawdlk-78rt9bh26smkuf3v0nd2ropp");

Console.WriteLine(response);
```

## UpdateWebhookSecretKeyAsync

Updates the webhook secret key

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/webhook-secret-key`

**Parameters**

| Name             | Type   | Required | Description                  |
| :--------------- | :----- | :------- | :--------------------------- |
| organizationName | string | ✅       | The unique organization name |

**Return Type**

`WebhookSecretKey`

**Example Usage Code Snippet**

```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.WebhookSecretKey.UpdateWebhookSecretKeyAsync("dyxdaqq1t3iwwpawdlk-78rt9bh26smkuf3v0nd2ropp");

Console.WriteLine(response);
```
