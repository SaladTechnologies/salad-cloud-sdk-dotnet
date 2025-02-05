```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

await client.ContainerGroups.DeleteContainerGroupAsync("phrf4wto3t0ce53c802dx4pj8udmjz-qc19k7j728", "sbqyjl1cz", "eiyuixb-h8eedpdp8k1km7fet2re1c36magozmsg");


```
