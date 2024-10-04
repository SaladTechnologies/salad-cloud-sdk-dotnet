```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.InferenceEndpoints.ListInferenceEndpointsAsync("wtxd1j0ixuhfk-hdff3n3-hbtsigyh53bt0g4gjh8mcz4", 121822981, 37);

Console.WriteLine(response);

```
