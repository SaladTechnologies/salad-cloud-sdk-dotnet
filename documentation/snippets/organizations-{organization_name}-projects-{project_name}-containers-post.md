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
var resources = new ContainerResourceRequirements(7, 35929, gpuClasses, 41532542137);
var command = new List<string>() { "command" };
var axiom = new AxiomLoggingConfiguration("host", "api_token", "dataset");
var tagsItem = new DatadogTagForContainerLogging("name", "value");
var tags = new List<DatadogTagForContainerLogging>() { tagsItem };
var datadog = new DatadogLoggingConfiguration("host", "api_key", tags);
var headersItem = new ContainerLoggingHttpHeader("name", "value");
var headers = new List<ContainerLoggingHttpHeader>() { headersItem };
var http = new ContainerLoggingConfigurationHttp2("host", 60321, ContainerLoggingHttpFormat.Json, ContainerLoggingHttpCompression.None, "user", "password", "path", headers);
var newRelic = new NewRelicLoggingConfiguration("host", "ingestion_key");
var splunk = new ContainerLoggingSplunkConfiguration("host", "token");
var tcp = new TcpLoggingConfiguration("host", 22816);
var logging = new ContainerConfigurationLogging(axiom, datadog, http, newRelic, splunk, tcp);
var awsEcr = new ContainerRegistryAuthenticationAwsEcr("access_key_id", "secret_access_key");
var basic = new ContainerRegistryAuthenticationBasic("username", "password");
var dockerHub = new ContainerRegistryAuthenticationDockerHub("username", "personal_access_token");
var gcpGar = new ContainerRegistryAuthenticationGcpGar("service_key");
var gcpGcr = new ContainerRegistryAuthenticationGcpGcr("service_key");
var registryAuthentication = new ContainerRegistryAuthentication(awsEcr, basic, dockerHub, gcpGar, gcpGcr);
var container = new ContainerConfiguration("acme/:latest", resources, command, new object(), true, logging, ContainerGroupPriority.High, registryAuthentication);
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(19846, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 3066, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(64068);
var livenessProbe = new ContainerGroupLivenessProbe(3, 958, 10, 1, 30, exec, grpc, http, tcp);
var networking = new CreateContainerGroupNetworking(true, 60000, ContainerNetworkingProtocol.Http, 100000, TheContainerGroupNetworkingLoadBalancer.RoundRobin, 100000, true);
var queueAutoscaler = new QueueBasedAutoscalerConfiguration(70, 94, 61, 91, 32, 1209);
var queueConnection = new ContainerGroupQueueConnection("path", 37873, "yc9z6");
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(19846, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 3066, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(64068);
var readinessProbe = new ContainerGroupReadinessProbe(3, 7, 1, 1, 1, exec, grpc, http, tcp);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(19846, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 3066, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(64068);
var startupProbe = new ContainerGroupStartupProbe(15, 676, 3, 2, 10, exec, grpc, http, tcp);
var input = new ContainerGroupCreationRequest(false, container, "name", 220, ContainerRestartPolicy.Always, countryCodes, "HH", livenessProbe, networking, queueAutoscaler, queueConnection, readinessProbe, startupProbe);

var response = await client.ContainerGroups.CreateContainerGroupAsync(input, "acme-corp", "dev-env");

Console.WriteLine(response);

```
