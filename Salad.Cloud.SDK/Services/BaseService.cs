using System.Text.Json;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Services;

public class BaseService
{
    protected readonly HttpClient _httpClient;
    protected readonly JsonSerializerOptions _jsonSerializerOptions;

    public BaseService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _jsonSerializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
        {
            Converters = { new ValueEnumJsonConverterFactory() }
        };
    }
}
