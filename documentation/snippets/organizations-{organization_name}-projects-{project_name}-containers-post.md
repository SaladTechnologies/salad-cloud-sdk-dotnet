```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var gpuClasses = new List<string>() { "gpu_classes" };
var resources = new CreateContainerResourceRequirements(827, 734164836, gpuClasses, 64, 761306530849177.9);
var command = new List<string>() { "command" };
var axiom = new AxiomLoggingConfiguration("api_token", "dataset", "host");
var tagsItem = new DatadogTagForContainerLogging("name", "value");
var tags = new List<DatadogTagForContainerLogging>() { tagsItem };
var datadog = new DatadogLoggingConfiguration("api_key", "host", tags);
var headersItem = new ContainerLoggingHttpHeader("name", "value");
var headers = new List<ContainerLoggingHttpHeader>() { headersItem };
var http = new ContainerLoggingConfigurationHttp2(ContainerLoggingHttpCompression.None, ContainerLoggingHttpFormat.Json, "host", 42056, headers, "password", "path", "user");
var newRelic = new NewRelicLoggingConfiguration("host", "ingestion_key");
var splunk = new ContainerLoggingSplunkConfiguration("host", "token");
var tcp = new TcpLoggingConfiguration("host", 44671);
var logging = new ContainerConfigurationLogging(axiom, datadog, http, newRelic, splunk, tcp);
var awsEcr = new ContainerRegistryAuthenticationAwsEcr("access_key_id", "secret_access_key");
var basic = new ContainerRegistryAuthenticationBasic("password", "username");
var dockerHub = new ContainerRegistryAuthenticationDockerHub("personal_access_token", "username");
var gcpGar = new ContainerRegistryAuthenticationGcpGar("service_key");
var gcpGcr = new ContainerRegistryAuthenticationGcpGcr("service_key");
var registryAuthentication = new ContainerRegistryAuthentication(awsEcr, basic, dockerHub, gcpGar, gcpGcr);
var container = new ContainerConfiguration("acme/:latest", resources, command, new object(), true, logging, ContainerGroupPriority.High, registryAuthentication);
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(37648, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 29069, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(13817);
var livenessProbe = new ContainerGroupLivenessProbe(3, 670, 10, 1, 30, exec, grpc, http, tcp);
var networking = new CreateContainerGroupNetworking(false, 60000, ContainerNetworkingProtocol.Http, 100000, TheContainerGroupNetworkingLoadBalancer.RoundRobin, 100000, false);
var queueAutoscaler = new QueueBasedAutoscalerConfiguration(53, 321, 54, 59, 100, 140);
var queueConnection = new ContainerGroupQueueConnection("path", 47568, "z1h-3z01x9");
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(37648, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 29069, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(13817);
var readinessProbe = new ContainerGroupReadinessProbe(3, 262, 1, 1, 1, exec, grpc, http, tcp);
var scalingActionsItem = new ContainerGroupScalingAction(461, "7kwC/T8C   da       x6Ci   bM-rgGYn     bDY6,vT");
var scalingActions = new List<ContainerGroupScalingAction>() { scalingActionsItem };
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(37648, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 29069, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(13817);
var startupProbe = new ContainerGroupStartupProbe(15, 503, 3, 2, 10, exec, grpc, http, tcp);
var input = new ContainerGroupCreationRequest(false, container, "name", 77, ContainerRestartPolicy.Always, countryCodes, "KMg0KyVwpb", livenessProbe, networking, queueAutoscaler, queueConnection, readinessProbe, scalingActions, true, startupProbe);

var response = await client.ContainerGroups.CreateContainerGroupAsync(input, "acme-corp", "dev-env");

Console.WriteLine(response);

```
