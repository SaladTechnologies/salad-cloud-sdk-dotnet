# InferenceEndpointJobPrototype

Represents a request to create a inference endpoint job

**Properties**

| Name       | Type   | Required | Description                                              |
| :--------- | :----- | :------- | :------------------------------------------------------- |
| Input\_    | object | ✅       | The job input. May be any valid JSON.                    |
| Metadata   | object | ❌       | The job metadata. May be any valid JSON.                 |
| Webhook    | string | ❌       | The webhook URL to which the job results will be POSTed. |
| WebhookUrl | string | ❌       | The webhook URL to which the job results will be POSTed. |
