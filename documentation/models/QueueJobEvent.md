# QueueJobEvent

Represents an event for queue job

**Properties**

| Name    | Type   | Required | Description |
| :------ | :----- | :------- | :---------- |
| Action1 | Action | ✅       |             |
| Time    | string | ✅       |             |

# Action

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Created   | string | ✅       | "created"   |
| Started   | string | ✅       | "started"   |
| Succeeded | string | ✅       | "succeeded" |
| Cancelled | string | ✅       | "cancelled" |
| Failed    | string | ✅       | "failed"    |
