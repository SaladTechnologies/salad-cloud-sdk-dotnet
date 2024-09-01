namespace SaladCloudSdk.Http;

/// <summary>
/// The environments available for the SDK.
/// </summary>
public class Environment
{
    internal Uri Uri { get; private set; }

    private Environment(string uri)
    {
        Uri = new Uri(uri);
    }

    public static Environment Default { get; } = new("https://api.salad.com/api/public/");
}
