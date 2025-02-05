```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.Quotas.GetQuotasAsync("j5rb91fzs3spaw4grzs1ulr8elj96ymws");

Console.WriteLine(response);

```
