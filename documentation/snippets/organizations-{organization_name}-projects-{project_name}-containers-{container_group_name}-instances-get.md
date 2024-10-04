```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.ListContainerGroupInstancesAsync("kjhy3jn2rdf012fi7ouno3mk-ax4d0ajj5ajjquzeg-z3kvqxtnoxnlzhi", "ft-8nawc40o0gqev-m", "jpy8af-s7rq68p2lenu");

Console.WriteLine(response);

```
