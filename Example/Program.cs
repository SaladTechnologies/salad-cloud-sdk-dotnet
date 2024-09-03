using SaladCloudSdk;
using SaladCloudSdk.Config;
using Environment = SaladCloudSdk.Http.Environment;

var apiKeyConfig = new ApiKeyAuthConfig("YOUR_API_KEY");

var config = new SaladCloudSdkConfig
{
    Environment = Environment.Default,
    ApiKeyAuth = apiKeyConfig
};

var client = new SaladCloudSdkClient(config);

var response = await client.Quotas.GetQuotasAsync("o110sou");

Console.WriteLine(response);
