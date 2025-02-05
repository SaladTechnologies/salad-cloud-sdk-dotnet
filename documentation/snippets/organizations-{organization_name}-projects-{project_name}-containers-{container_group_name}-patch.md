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
var resources1 = new Resources(11, 11298, gpuClasses, 46759285941);
var command = new List<string>() { "command" };
var axiom = new LoggingAxiom3("host", "api_token", "dataset");
var tagsItem = new DatadogTags3("name", "value");
var tags = new List<DatadogTags3>() { tagsItem };
var datadog = new LoggingDatadog3("host", "api_key", tags);
var newRelic = new LoggingNewRelic3("host", "ingestion_key");
var splunk = new LoggingSplunk3("host", "token");
var tcp = new LoggingTcp3("host", 10152);
var headersItem = new HttpHeaders4("name", "value");
var headers = new List<HttpHeaders4>() { headersItem };
var http = new LoggingHttp3("host", 35767, HttpFormat3.Json, HttpCompression3.None, "user", "password", "path", headers);
var logging = new UpdateContainerLogging(axiom, datadog, newRelic, splunk, tcp, http);
var basic = new RegistryAuthenticationBasic2("username", "password");
var gcpGcr = new RegistryAuthenticationGcpGcr2("service_key");
var awsEcr = new RegistryAuthenticationAwsEcr2("access_key_id", "secret_access_key");
var dockerHub = new RegistryAuthenticationDockerHub2("username", "personal_access_token");
var gcpGar = new RegistryAuthenticationGcpGar2("service_key");
var registryAuthentication = new UpdateContainerRegistryAuthentication(basic, gcpGcr, awsEcr, dockerHub, gcpGar);
var container = new UpdateContainer("image", resources1, command, ContainerGroupPriority.High, new object(), logging, registryAuthentication);
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var networking = new UpdateContainerGroupNetworking(42727);
var tcp = new ContainerGroupProbeTcp(17650);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 18332, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 34595);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var livenessProbe = new ContainerGroupLivenessProbe(10, 10, 30, 1, 3, tcp, http, grpc, exec);
var tcp = new ContainerGroupProbeTcp(17650);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 18332, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 34595);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var readinessProbe = new ContainerGroupReadinessProbe(2, 1, 1, 1, 3, tcp, http, grpc, exec);
var tcp = new ContainerGroupProbeTcp(17650);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 18332, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 34595);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var startupProbe = new ContainerGroupStartupProbe(7, 3, 10, 2, 1200, tcp, http, grpc, exec);
var queueAutoscaler = new QueueAutoscaler(95, 169, 22, 322, 92, 26);
var input = new UpdateContainerGroup("tDW4Ah", container, 78, countryCodes, networking, livenessProbe, readinessProbe, startupProbe, queueAutoscaler);

var response = await client.ContainerGroups.UpdateContainerGroupAsync(input, "phrf4wto3t0ce53c802dx4pj8udmjz-qc19k7j728", "sbqyjl1cz", "eiyuixb-h8eedpdp8k1km7fet2re1c36magozmsg");

Console.WriteLine(response);

```
