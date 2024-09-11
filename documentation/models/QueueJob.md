# QueueJob

Represents a queue job

**Properties**

| Name       | Type                  | Required | Description                            |
| :--------- | :-------------------- | :------- | :------------------------------------- |
| Id         | `string`              | ✅       |                                        |
| Input\_    | `object`              | ✅       | The job input. May be any valid JSON.  |
| Status     | `QueueJobStatus`      | ✅       |                                        |
| Events     | `List<QueueJobEvent>` | ✅       |                                        |
| CreateTime | `string`              | ✅       |                                        |
| UpdateTime | `string`              | ✅       |                                        |
| Metadata   | `object`              | ❌       |                                        |
| Webhook    | `string`              | ❌       |                                        |
| Output     | `object`              | ❌       | The job output. May be any valid JSON. |

# QueueJobStatus

**Properties**

| Name      | Type     | Required | Description |
| :-------- | :------- | :------- | :---------- |
| Pending   | `string` | ✅       | "pending"   |
| Running   | `string` | ✅       | "running"   |
| Succeeded | `string` | ✅       | "succeeded" |
| Cancelled | `string` | ✅       | "cancelled" |
| Failed    | `string` | ✅       | "failed"    |
