using System.Text.Json;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Services;

/// <summary>
/// Base service class providing core HTTP request execution and JSON serialization for all service endpoints.
/// </summary>
public class BaseService
{
    protected readonly HttpClient _httpClient;
    protected readonly JsonSerializerOptions _jsonSerializerOptions;

    public BaseService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _jsonSerializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
        {
            Converters = { new ValueEnumJsonConverterFactory() },
        };
    }
}
