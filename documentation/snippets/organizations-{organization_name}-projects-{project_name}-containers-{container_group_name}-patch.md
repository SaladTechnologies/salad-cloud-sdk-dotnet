```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;

var config = new SaladCloudSdkConfig{};

var client = new SaladCloudSdkClient(config);

var command = new List<string>() { "command" };
var axiom = new AxiomLoggingConfiguration("api_token", "dataset", "host");
var tagsItem = new DatadogTagForContainerLogging("name", "value");
var tags = new List<DatadogTagForContainerLogging>() { tagsItem };
var datadog = new DatadogLoggingConfiguration("api_key", "host", tags);
var headersItem = new ContainerLoggingHttpHeader("name", "value");
var headers = new List<ContainerLoggingHttpHeader>() { headersItem };
var http = new ContainerLoggingConfigurationHttp1(ContainerLoggingHttpCompression.None, ContainerLoggingHttpFormat.Json, headers, "host", 55354, "password", "path", "user");
var newRelic = new NewRelicLoggingConfiguration("host", "ingestion_key");
var splunk = new ContainerLoggingSplunkConfiguration("host", "token");
var tcp = new TcpLoggingConfiguration("host", 44671);
var logging = new UpdateContainerLogging(axiom, datadog, http, newRelic, splunk, tcp);
var awsEcr = new ContainerRegistryAuthenticationAwsEcr("access_key_id", "secret_access_key");
var basic = new ContainerRegistryAuthenticationBasic("password", "username");
var dockerHub = new ContainerRegistryAuthenticationDockerHub("personal_access_token", "username");
var gcpGar = new ContainerRegistryAuthenticationGcpGar("service_key");
var gcpGcr = new ContainerRegistryAuthenticationGcpGcr("service_key");
var registryAuthentication = new ContainerRegistryAuthentication(awsEcr, basic, dockerHub, gcpGar, gcpGcr);
var gpuClasses = new List<string>() { "gpu_classes" };
var resources = new ContainerResourceUpdateSchema(191, gpuClasses, 909130690, 64, 699558298076245);
var container = new UpdateContainer(command, new object(), "image", true, logging, ContainerGroupPriority.High, registryAuthentication, resources);
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(37648, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 29069, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(13817);
var livenessProbe = new ContainerGroupLivenessProbe(3, 670, 10, 1, 30, exec, grpc, http, tcp);
var networking = new UpdateContainerGroupNetworking(17025);
var queueAutoscaler = new QueueBasedAutoscalerConfiguration(53, 321, 54, 59, 100, 140);
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
var input = new ContainerGroupPatch(container, countryCodes, "ykW8yoj HBQ", livenessProbe, networking, queueAutoscaler, readinessProbe, 102, scalingActions, true, startupProbe);

var response = await client.ContainerGroups.UpdateContainerGroupAsync(input, "acme-corp", "dev-env", "mandlebrot");

Console.WriteLine(response);

```
