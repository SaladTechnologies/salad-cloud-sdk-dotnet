```csharp
using SaladCloudSdk;

var client = new SaladCloudSdkClient();

var response = await client.ContainerGroups.ListContainerGroupInstancesAsync("i5dt471e81flms65ujlnugscfp5-4x1xl1-c1ax257sioy7vldsm", "hwxbxx0fdtl98ziqbie46xqcbddvaoe06qhpuoplm89wi1", "y4q9cpfigd95ewlngasgx2e93zxeimrri0-iro9w0j3jvvgj2awj6-0ivo87g");

Console.WriteLine(response);

```
