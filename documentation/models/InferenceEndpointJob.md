# InferenceEndpointJob

Represents a inference endpoint job

**Properties**

| Name                  | Type                            | Required | Description                            |
| :-------------------- | :------------------------------ | :------- | :------------------------------------- |
| Id                    | string                          | ✅       |                                        |
| Input\_               | object                          | ✅       | The job input. May be any valid JSON.  |
| InferenceEndpointName | string                          | ✅       | The inference endpoint name            |
| Status                | InferenceEndpointJobStatus      | ✅       |                                        |
| Events                | List<InferenceEndpointJobEvent> | ✅       |                                        |
| OrganizationName      | string                          | ✅       | The organization name                  |
| CreateTime            | string                          | ✅       |                                        |
| UpdateTime            | string                          | ✅       |                                        |
| Metadata              | object                          | ❌       |                                        |
| Webhook               | string                          | ❌       |                                        |
| Output                | object                          | ❌       | The job output. May be any valid JSON. |

# InferenceEndpointJobStatus

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Pending   | string | ✅       | "pending"   |
| Running   | string | ✅       | "running"   |
| Succeeded | string | ✅       | "succeeded" |
| Cancelled | string | ✅       | "cancelled" |
| Failed    | string | ✅       | "failed"    |
