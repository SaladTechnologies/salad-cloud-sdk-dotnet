```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new CreateQueue("wcaz2jbu5pfmpygxffsf4bh4e6");

var response = await client.Queues.CreateQueueAsync(input, "rtxaydgbmb5wprcvb9628akhug9lnd3c0", "p4bdb9jsi-f1xex70mdgjf5n-5ua-e28xyu9ujbls0vsz6xilo12xl52y9c177");

Console.WriteLine(response);

```
