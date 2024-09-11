# InferenceEndpointJobEvent

Represents an event for inference endpoint job

**Properties**

| Name   | Type                              | Required | Description |
| :----- | :-------------------------------- | :------- | :---------- |
| Action | `InferenceEndpointJobEventAction` | ✅       |             |
| Time   | `string`                          | ✅       |             |

# InferenceEndpointJobEventAction

**Properties**

| Name      | Type     | Required | Description |
| :-------- | :------- | :------- | :---------- |
| Created   | `string` | ✅       | "created"   |
| Started   | `string` | ✅       | "started"   |
| Succeeded | `string` | ✅       | "succeeded" |
| Cancelled | `string` | ✅       | "cancelled" |
| Failed    | `string` | ✅       | "failed"    |
