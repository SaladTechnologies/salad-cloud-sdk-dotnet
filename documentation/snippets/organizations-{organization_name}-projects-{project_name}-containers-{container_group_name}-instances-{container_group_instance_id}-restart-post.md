```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.RestartContainerGroupInstanceAsync("b57migu1lyx2k-vmo4k1art82l9sdmly5tasmph2ghb5osc8i5s", "egpw6pdom937z6qj42uo7yis0ws", "c1x72p43xkkp5xyjtjud-whejhmajx6at62-3go1ea-qh", "container_group_instance_id");


```
