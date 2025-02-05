```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.ContainerGroups.ListContainerGroupsAsync("jnuv8vtkwt5jf", "br--nh24d-sd3k8zhse2b17rr6qt35mgt0w7nmi1bhe");

Console.WriteLine(response);

```
