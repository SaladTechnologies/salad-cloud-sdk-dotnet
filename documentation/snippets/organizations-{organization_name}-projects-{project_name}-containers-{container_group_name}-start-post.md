```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.StartContainerGroupAsync("xzb5h40r3d-tbpmdwz42hxn6mm7gyt2lmzz4brddw4nq6cv0x76n2zwuhx", "z6a9qgyutmphvjh8k01czhll2fdh", "j3eo");


```
