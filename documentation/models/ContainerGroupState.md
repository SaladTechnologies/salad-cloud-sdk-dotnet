# ContainerGroupState

Represents a container group state

**Properties**

| Name                 | Type                                | Required | Description                                        |
| :------------------- | :---------------------------------- | :------- | :------------------------------------------------- |
| Status               | `ContainerGroupStatus`              | ✅       |                                                    |
| StartTime            | `string`                            | ✅       |                                                    |
| FinishTime           | `string`                            | ✅       |                                                    |
| InstanceStatusCounts | `ContainerGroupInstanceStatusCount` | ✅       | Represents a container group instance status count |
| Description          | `string`                            | ❌       |                                                    |
