# InferenceEndpointJob

Represents a inference endpoint job

**Properties**

| Name                  | Type                            | Required | Description                                    |
| :-------------------- | :------------------------------ | :------- | :--------------------------------------------- |
| Id                    | string                          | ✅       | The inference endpoint job identifier.         |
| InferenceEndpointName | string                          | ✅       | The inference endpoint name.                   |
| OrganizationName      | string                          | ✅       | The organization name.                         |
| Input\_               | object                          | ✅       | The job input. May be any valid JSON.          |
| Status                | Status                          | ✅       | The current status.                            |
| Events                | List<InferenceEndpointJobEvent> | ✅       | The list of events.                            |
| CreateTime            | string                          | ✅       | The time the job was created.                  |
| UpdateTime            | string                          | ✅       | The time the job was last updated.             |
| Metadata              | object                          | ❌       | The job metadata. May be any valid JSON.       |
| Webhook               | string                          | ❌       | The webhook URL called when the job completes. |
| WebhookUrl            | string                          | ❌       | The webhook URL called when the job completes. |
| Output                | object                          | ❌       | The job output. May be any valid JSON.         |
