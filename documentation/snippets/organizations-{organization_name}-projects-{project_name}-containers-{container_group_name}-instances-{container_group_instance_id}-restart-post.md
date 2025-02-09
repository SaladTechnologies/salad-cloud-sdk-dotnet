```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.RestartContainerGroupInstanceAsync("acme-corp", "dev-env", "elwyv8cc9z7auxq8gmm5tqiz3fh3lty-n963c-nzs6rcc8qglueef-fdu", "container_group_instance_id");


```
