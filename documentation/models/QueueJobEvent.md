# QueueJobEvent

Represents an event for queue job

**Properties**

| Name   | Type                | Required | Description |
| :----- | :------------------ | :------- | :---------- |
| Action | QueueJobEventAction | ✅       |             |
| Time   | string              | ✅       |             |

# QueueJobEventAction

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Created   | string | ✅       | "created"   |
| Started   | string | ✅       | "started"   |
| Succeeded | string | ✅       | "succeeded" |
| Cancelled | string | ✅       | "cancelled" |
| Failed    | string | ✅       | "failed"    |
