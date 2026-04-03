```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var gpuClasses = new List<string>() { "gpu_classes" };
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var input = new GpuAvailabilityPrototype(gpuClasses, countryCodes, 4, 8192, 1000000000);

var response = await client.Organizations.GetGpuAvailabilityAsync(input, "acme-corp");

Console.WriteLine(response);

```
