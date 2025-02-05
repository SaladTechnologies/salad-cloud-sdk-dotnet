```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.ContainerGroups.GetContainerGroupInstanceAsync("h2vf5j9bl68odxyrub2vzqrpq", "dz0l0ksd13duaemr1bl6h3cfj", "qt5kcqqmsto9eh5guxaf9", "container_group_instance_id");

Console.WriteLine(response);

```
