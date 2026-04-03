# QueueJob

Represents a queue job

**Properties**

| Name       | Type                                    | Required | Description                                      |
| :--------- | :-------------------------------------- | :------- | :----------------------------------------------- |
| CreateTime | string                                  | ✅       | The job creation time                            |
| Events     | List<[QueueJobEvent](QueueJobEvent.md)> | ✅       | The job events                                   |
| Id         | string                                  | ✅       | The job identifier                               |
| Input\_    | object                                  | ✅       | The job input. May be any valid JSON.            |
| Status     | QueueJobStatus                          | ✅       | The job status                                   |
| UpdateTime | string                                  | ✅       | The job update time                              |
| Metadata   | object                                  | ❌       | Additional metadata for the job                  |
| Output     | object                                  | ❌       | The job output. May be any valid JSON.           |
| Webhook    | string                                  | ❌       | The webhook URL to notify when the job completes |

# QueueJobStatus

The job status

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Pending   | string | ✅       | "pending"   |
| Running   | string | ✅       | "running"   |
| Succeeded | string | ✅       | "succeeded" |
| Cancelled | string | ✅       | "cancelled" |
| Failed    | string | ✅       | "failed"    |
