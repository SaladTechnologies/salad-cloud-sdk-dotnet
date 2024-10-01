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

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |

**Return Type**

`WebhookSecretKey`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.WebhookSecretKey.GetWebhookSecretKeyAsync("wmkuf3v0nd2roppi64zikv73wys88ns81");

Console.WriteLine(response);
```

## UpdateWebhookSecretKeyAsync

Updates the webhook secret key

- HTTP Method: `POST`
- Endpoint: `/organizations/{organization_name}/webhook-secret-key`

**Parameters**

| Name             | Type   | Required | Description                                                                                                                                                                                                                                         |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| organizationName | string | ✅       | Your organization name. This identifies the billing context for the API operation and represents a security boundary for SaladCloud resources. The organization must be created before using the API, and you must be a member of the organization. |

**Return Type**

`WebhookSecretKey`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.WebhookSecretKey.UpdateWebhookSecretKeyAsync("wmkuf3v0nd2roppi64zikv73wys88ns81");

Console.WriteLine(response);
```
