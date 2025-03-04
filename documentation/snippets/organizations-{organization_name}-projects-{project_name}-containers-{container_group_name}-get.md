```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.ContainerGroups.GetContainerGroupAsync("acme-corp", "dev-env", "ja8mepeueo5-1hcilmn8m1ouq40vp547cf-8");

Console.WriteLine(response);

```
