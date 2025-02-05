```csharp
using Salad.Cloud.SDK;
using Salad.Cloud.SDK.Config;
using Environment = Salad.Cloud.SDK.Http.Environment;

var config = new SaladCloudSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudSdkClient(config);

var response = await client.Queues.GetQueueJobAsync("oo-uft3mtt7tcxqcq1m0iarq", "b1qjwjc4vf99pxxwtres8z9zwaod8ipjrui87jo", "m2s0izl8d-g9wqh8bjget2tyh4q9ni9h81tilnlnf5i-r38a8vv5h4l", "queue_job_id");

Console.WriteLine(response);

```
