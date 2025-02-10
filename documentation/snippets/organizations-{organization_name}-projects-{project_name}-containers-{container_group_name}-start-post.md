```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.StartContainerGroupAsync("acme-corp", "dev-env", "gftm9dd5sl3zq4c9ycai8jt4kduxxniyomose4errderfez5m6znpd");


```
