```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.ReallocateContainerGroupInstanceAsync("acme-corp", "dev-env", "rlr6585lj2n", "container_group_instance_id");


```
