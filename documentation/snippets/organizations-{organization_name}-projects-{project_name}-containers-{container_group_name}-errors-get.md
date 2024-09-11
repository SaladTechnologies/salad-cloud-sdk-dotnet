```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.WorkloadErrors.GetWorkloadErrorsAsync("kr8pje-v4-ccp8q-329szw31h4fee237cnffybnugpd7nbngr", "vjne2vq5j0d2m4f21ex5ozb1-4j-you0d7uftlpfgcaqa-2oc58y844mz", "jpqhlkkgd");

Console.WriteLine(response);

```
