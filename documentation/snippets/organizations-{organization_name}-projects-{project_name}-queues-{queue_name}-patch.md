```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Models;

var client = new SaladCloudSdkClient();

var input = new UpdateQueue();

var response = await client.Queues.UpdateQueueAsync(input, "bb5wprcvb9628akhug9lnd2", "bw-4bdb9jsi-f1xex70mdgjf5n-5ua-e28xyu9ujbls0vsy", "wilo12xl52y9c178cmdya6ykpby-hunb0b6s7s2l");

Console.WriteLine(response);

```
