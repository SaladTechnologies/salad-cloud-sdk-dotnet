# ContainerGroupsQuotas

Represents the organization quotas for container groups

**Properties**

| Name                                    | Type | Required | Description                                                              |
| :-------------------------------------- | :--- | :------- | :----------------------------------------------------------------------- |
| MaxCreatedContainerGroups               | long | ❌       | The maximum number of container groups that can be created               |
| ContainerInstanceQuota                  | long | ❌       | The maximum number of replicas that can be created for a container group |
| ContainerReplicaQuota                   | long | ❌       | The maximum number of replicas that can be created for a container group |
| ContainerReplicasUsed                   | long | ❌       | The number of replicas that are currently in use                         |
| MaxContainerGroupReallocationsPerMinute | long | ❌       | The maximum number of container group reallocations per minute           |
| MaxContainerGroupRecreatesPerMinute     | long | ❌       | The maximum number of container group recreates per minute               |
| MaxContainerGroupRestartsPerMinute      | long | ❌       | The maximum number of container group restarts per minute                |
