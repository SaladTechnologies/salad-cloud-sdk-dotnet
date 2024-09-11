```csharp
using Salad.Cloud.SDK;

var client = new SaladCloudSdkClient();

var response = await client.WorkloadErrors.GetWorkloadErrorsAsync("u9szw31h4fee237cnffybnugpd7nbngs47jne2vq5j0d2m4f20", "c5ozb1-4j-you0d7uftlpfgcaqa-2oc58y844m0ne", "khlkkgda39h5upyur493wxwbxrj4x");

Console.WriteLine(response);

```
