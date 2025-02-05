```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.RecreateContainerGroupInstanceAsync("es2bv9qahh8", "t11t96rt97nfp9ty6rdemn82q46bz0o-09fev9p45si7totf5aobxwodsb44xub", "cok7vgd5d7rlx-e9sc8oj3xc", "container_group_instance_id");


```
