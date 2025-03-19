# QueueJobEvent

Represents an event for queue job

**Properties**

| Name    | Type   | Required | Description                                    |
| :------ | :----- | :------- | :--------------------------------------------- |
| Action1 | Action | ✅       | The action that was taken on the queue job     |
| Time    | string | ✅       | The time the action was taken on the queue job |

# Action

The action that was taken on the queue job

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Created   | string | ✅       | "created"   |
| Started   | string | ✅       | "started"   |
| Succeeded | string | ✅       | "succeeded" |
| Cancelled | string | ✅       | "cancelled" |
| Failed    | string | ✅       | "failed"    |
