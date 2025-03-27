```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Salad.Cloud.SDK.Models;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var command = new List<string>() { "command" };
var axiom = new AxiomLoggingConfiguration("host", "api_token", "dataset");
var tagsItem = new DatadogTagForContainerLogging("name", "value");
var tags = new List<DatadogTagForContainerLogging>() { tagsItem };
var datadog = new DatadogLoggingConfiguration("host", "api_key", tags);
var headersItem = new ContainerLoggingHttpHeader("name", "value");
var headers = new List<ContainerLoggingHttpHeader>() { headersItem };
var http = new ContainerLoggingConfigurationHttp1("host", 17296, ContainerLoggingHttpFormat.Json, headers, ContainerLoggingHttpCompression.None, "user", "password", "path");
var newRelic = new NewRelicLoggingConfiguration("host", "ingestion_key");
var splunk = new ContainerLoggingSplunkConfiguration("host", "token");
var tcp = new TcpLoggingConfiguration("host", 35279);
var logging = new UpdateContainerLogging(axiom, datadog, http, newRelic, splunk, tcp);
var awsEcr = new ContainerRegistryAuthenticationAwsEcr("access_key_id", "secret_access_key");
var basic = new ContainerRegistryAuthenticationBasic("username", "password");
var dockerHub = new ContainerRegistryAuthenticationDockerHub("username", "personal_access_token");
var gcpGar = new ContainerRegistryAuthenticationGcpGar("service_key");
var gcpGcr = new ContainerRegistryAuthenticationGcpGcr("service_key");
var registryAuthentication = new ContainerRegistryAuthentication(awsEcr, basic, dockerHub, gcpGar, gcpGcr);
var gpuClasses = new List<string>() { "gpu_classes" };
var resources = new ContainerResourceUpdateSchema(10, 22157, gpuClasses, 53149991828);
var container = new UpdateContainer(command, new object(), "image", true, logging, ContainerGroupPriority.High, registryAuthentication, resources);
var countryCodes = new List<CountryCode>() { CountryCode.Af };
var networking = new UpdateContainerGroupNetworking(43586);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(7022, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 60740, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(42000);
var livenessProbe = new ContainerGroupLivenessProbe(3, 208, 10, 1, 30, exec, grpc, http, tcp);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(7022, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 60740, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(42000);
var readinessProbe = new ContainerGroupReadinessProbe(3, 137, 1, 1, 1, exec, grpc, http, tcp);
var command = new List<string>() { "command" };
var exec = new ContainerGroupProbeExec(command);
var grpc = new ContainerGroupGRpcProbe(7022, "service");
var headersItem = new ContainerGroupProbeHttpHeader("name", "value");
var headers = new List<ContainerGroupProbeHttpHeader>() { headersItem };
var http = new ContainerGroupHttpProbeConfiguration(headers, "path", 60740, HttpScheme.Http);
var tcp = new ContainerGroupTcpProbe(42000);
var startupProbe = new ContainerGroupStartupProbe(15, 741, 3, 2, 10, exec, grpc, http, tcp);
var queueAutoscaler = new QueueBasedAutoscalerConfiguration(65, 288, 21, 45, 56, 1604);
var input = new ContainerGroupPatch("be", container, 412, countryCodes, networking, livenessProbe, readinessProbe, startupProbe, queueAutoscaler);

var response = await client.ContainerGroups.UpdateContainerGroupAsync(input, "acme-corp", "dev-env", "mandlebrot");

Console.WriteLine(response);

```
