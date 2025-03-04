```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var gpuClasses = new List<string>() { "gpu_classes" };
var resources1 = new Resources(9, 13952, gpuClasses, 50215025854);
var command = new List<string>() { "command" };
var axiom = new LoggingAxiom3("host", "api_token", "dataset");
var tagsItem = new DatadogTags3("name", "value");
var tags = new List<DatadogTags3>() { tagsItem };
var datadog = new LoggingDatadog3("host", "api_key", tags);
var newRelic = new LoggingNewRelic3("host", "ingestion_key");
var splunk = new LoggingSplunk3("host", "token");
var tcp = new LoggingTcp3("host", 34769);
var headersItem = new HttpHeaders4("name", "value");
var headers = new List<HttpHeaders4>() { headersItem };
var http = new LoggingHttp3("host", 17361, HttpFormat3.Json, HttpCompression3.None, "user", "password", "path", headers);
var logging = new UpdateContainerLogging(axiom, datadog, newRelic, splunk, tcp, http);
var basic = new RegistryAuthenticationBasic2("username", "password");
var gcpGcr = new RegistryAuthenticationGcpGcr2("service_key");
var awsEcr = new RegistryAuthenticationAwsEcr2("access_key_id", "secret_access_key");
var dockerHub = new RegistryAuthenticationDockerHub2("username", "personal_access_token");
var gcpGar = new RegistryAuthenticationGcpGar2("service_key");
var registryAuthentication = new UpdateContainerRegistryAuthentication(basic, gcpGcr, awsEcr, dockerHub, gcpGar);
var container = new UpdateContainer("image", resources1, command, ContainerGroupPriority.High, new object(), logging, registryAuthentication, true);
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var networking = new UpdateContainerGroupNetworking(55354);
var tcp = new ContainerGroupProbeTcp(22350);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 56884, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 47172);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var livenessProbe = new ContainerGroupLivenessProbe(0, 10, 30, 1, 3, tcp, http, grpc, exec);
var tcp = new ContainerGroupProbeTcp(22350);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 56884, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 47172);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var readinessProbe = new ContainerGroupReadinessProbe(0, 1, 1, 1, 3, tcp, http, grpc, exec);
var tcp = new ContainerGroupProbeTcp(22350);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 56884, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 47172);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var startupProbe = new ContainerGroupStartupProbe(9, 3, 10, 2, 1200, tcp, http, grpc, exec);
var queueAutoscaler = new QueueAutoscaler(26, 55, 42, 442, 3, 69);
var input = new UpdateContainerGroup("Kme,2D", container, 12, countryCodes, networking, livenessProbe, readinessProbe, startupProbe, queueAutoscaler);

var response = await client.ContainerGroups.UpdateContainerGroupAsync(input, "acme-corp", "dev-env", "ja8mepeueo5-1hcilmn8m1ouq40vp547cf-8");

Console.WriteLine(response);

```
