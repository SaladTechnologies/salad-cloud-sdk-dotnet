```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.ReallocateContainerGroupInstanceAsync("zysw-tw2j90oxr-iu0br008wldxnn5wweelngjy-e4653f7g56e1xtjxxabek", "ilq3woz0e08jg-wlalvrmhj6xzap3kodtp7vguu", "bu0ebi0d6boaz4q0eaasthaluhnqd9xq6h5216lsww", "container_group_instance_id");


```
