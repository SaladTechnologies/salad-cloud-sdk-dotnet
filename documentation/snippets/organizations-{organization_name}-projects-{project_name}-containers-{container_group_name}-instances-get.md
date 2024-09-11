```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.ListContainerGroupInstancesAsync("dcbh1", "pdcapp3enb9gd2f4k49vviu53s67ckwwnxsd-gfjsmuxcljdg4t1zzyoj", "vl2kuh4c67m3ae7qwlwipkdye-ad");

Console.WriteLine(response);

```
