# InferenceEndpointJob

Represents a inference endpoint job

**Properties**

| Name                  | Type                            | Required | Description                                    |
| :-------------------- | :------------------------------ | :------- | :--------------------------------------------- |
| Id                    | string                          | ✅       | The unique identifier.                         |
| Input\_               | object                          | ✅       | The job input. May be any valid JSON.          |
| InferenceEndpointName | string                          | ✅       | The inference endpoint name.                   |
| Status                | InferenceEndpointJobStatus      | ✅       | The current status.                            |
| Events                | List<InferenceEndpointJobEvent> | ✅       | The list of events.                            |
| OrganizationName      | string                          | ✅       | The organization name.                         |
| CreateTime            | string                          | ✅       | The time the job was created.                  |
| UpdateTime            | string                          | ✅       | The time the job was last updated.             |
| Metadata              | object                          | ❌       | The job metadata. May be any valid JSON.       |
| Webhook               | string                          | ❌       | The webhook URL called when the job completes. |
| Output                | object                          | ❌       | The job output. May be any valid JSON.         |

# InferenceEndpointJobStatus

The current status.

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Pending   | string | ✅       | "pending"   |
| Running   | string | ✅       | "running"   |
| Succeeded | string | ✅       | "succeeded" |
| Cancelled | string | ✅       | "cancelled" |
| Failed    | string | ✅       | "failed"    |
