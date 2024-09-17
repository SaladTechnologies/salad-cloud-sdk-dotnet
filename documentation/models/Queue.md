# Queue

Represents a queue.

**Properties**

| Name            | Type                 | Required | Description                                                                                   |
| :-------------- | :------------------- | :------- | :-------------------------------------------------------------------------------------------- |
| Id              | string               | ✅       | The queue identifier. This is automatically generated and assigned when the queue is created. |
| Name            | string               | ✅       | The queue name. This must be unique within the project.                                       |
| DisplayName     | string               | ✅       | The display name. This may be used as a more human-readable name.                             |
| ContainerGroups | List<ContainerGroup> | ✅       |                                                                                               |
| CreateTime      | string               | ✅       | The date and time the queue was created.                                                      |
| UpdateTime      | string               | ✅       | The date and time the queue was last updated.                                                 |
| Description     | string               | ❌       | The description. This may be used as a space for notes or other information about the queue.  |
