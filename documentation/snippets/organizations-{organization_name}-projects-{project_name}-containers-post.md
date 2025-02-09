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
var resources = new ContainerResourceRequirements(3, 16094, gpuClasses, 50473301867);
var command = new List<string>() { "command" };
var axiom = new LoggingAxiom2("host", "api_token", "dataset");
var tagsItem = new DatadogTags2("name", "value");
var tags = new List<DatadogTags2>() { tagsItem };
var datadog = new LoggingDatadog2("host", "api_key", tags);
var newRelic = new LoggingNewRelic2("host", "ingestion_key");
var splunk = new LoggingSplunk2("host", "token");
var tcp = new LoggingTcp2("host", 52754);
var headersItem = new HttpHeaders3("name", "value");
var headers = new List<HttpHeaders3>() { headersItem };
var http = new LoggingHttp2("host", 58619, HttpFormat2.Json, HttpCompression2.None, "user", "password", "path", headers);
var logging = new CreateContainerLogging(axiom, datadog, newRelic, splunk, tcp, http);
var basic = new RegistryAuthenticationBasic1("username", "password");
var gcpGcr = new RegistryAuthenticationGcpGcr1("service_key");
var awsEcr = new RegistryAuthenticationAwsEcr1("access_key_id", "secret_access_key");
var dockerHub = new RegistryAuthenticationDockerHub1("username", "personal_access_token");
var gcpGar = new RegistryAuthenticationGcpGar1("service_key");
var registryAuthentication = new CreateContainerRegistryAuthentication(basic, gcpGcr, awsEcr, dockerHub, gcpGar);
var container = new CreateContainer("image", resources, command, ContainerGroupPriority.High, new object(), logging, registryAuthentication);
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var networking = new CreateContainerGroupNetworking(ContainerNetworkingProtocol.Http, 64929, true, CreateContainerGroupNetworkingLoadBalancer.RoundRobin, true, 100000, 100000);
var tcp = new ContainerGroupProbeTcp(9366);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 398, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 23866);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var livenessProbe = new ContainerGroupLivenessProbe(1, 10, 30, 1, 3, tcp, http, grpc, exec);
var tcp = new ContainerGroupProbeTcp(9366);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 398, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 23866);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var readinessProbe = new ContainerGroupReadinessProbe(8, 1, 1, 1, 3, tcp, http, grpc, exec);
var tcp = new ContainerGroupProbeTcp(9366);
var headersItem = new ContainerGroupProbeHttpHeaders2("name", "value");
var headers = new List<ContainerGroupProbeHttpHeaders2>() { headersItem };
var http = new ContainerGroupProbeHttp("path", 398, ContainerProbeHttpScheme.Http, headers);
var grpc = new ContainerGroupProbeGrpc("service", 23866);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var startupProbe = new ContainerGroupStartupProbe(2, 3, 10, 2, 1200, tcp, http, grpc, exec);
var queueConnection = new ContainerGroupQueueConnection("path", 34806, "r3qna2yfhck403bsaqbf6nweyawtm7q4ohr");
var queueAutoscaler = new QueueAutoscaler(88, 197, 57, 1449, 85, 33);
var input = new CreateContainerGroup("name", container, true, ContainerRestartPolicy.Always, 47, "ny", countryCodes, networking, livenessProbe, readinessProbe, startupProbe, queueConnection, queueAutoscaler);

var response = await client.ContainerGroups.CreateContainerGroupAsync(input, "acme-corp", "dev-env");

Console.WriteLine(response);

```
