```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var countryCodes = new List<CountryCode>() { CountryCode.Af };
var input = new CpuAvailabilityPrototype(countryCodes, 4, 8192, 1000000000);

var response = await client.Organizations.GetCpuAvailabilityAsync(input, "acme-corp");

Console.WriteLine(response);

```
