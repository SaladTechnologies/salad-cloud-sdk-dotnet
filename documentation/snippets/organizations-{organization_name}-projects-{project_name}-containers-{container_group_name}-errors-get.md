```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.WorkloadErrors.GetWorkloadErrorsAsync("acme-corp", "dev-env", "tnwhnwotbabfm2itldawrgfpnpeeez");

Console.WriteLine(response);

```
