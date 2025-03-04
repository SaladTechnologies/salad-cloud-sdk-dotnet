```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.ContainerGroups.GetContainerGroupInstanceAsync("acme-corp", "dev-env", "djh4s8hz0soygun3m687oust14ot1pk0icevxf5izkd-rds", "container_group_instance_id");

Console.WriteLine(response);

```
