```csharp
using SaladCloudSdk;
using SaladCloudSdk.Models;

var client = new SaladCloudSdkClient();

var input = new UpdateQueue();

var response = await client.Queues.UpdateQueueAsync(input, "voe5nrfsnef63doc193sgdihl8bgcxw201b7qbn", "xlauk07eld4q4sm9jdgi4bgl1flz0elvw26099ougowft9j-kjp6bahz155", "gsomvfqk5h4gbc8o3p4id29bdadte3m51it2hfzxfmyjtvnd0b");

Console.WriteLine(response);

```
