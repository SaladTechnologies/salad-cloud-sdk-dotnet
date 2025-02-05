```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.StopContainerGroupAsync("wnsjao1m6q6-so4tp1yhwjdpa4rchjtb6qp-hyt0s34pmjpl9", "pax9xqfzcvrc7mgqfff4pyapsn5bpfu5tn1dw9fek5en16s", "spxtjyr20teh5er84k");


```
