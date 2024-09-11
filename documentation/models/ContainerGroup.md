# ContainerGroup

Represents a container group

**Properties**

| Name            | Type                            | Required | Description                                                                                     |
| :-------------- | :------------------------------ | :------- | :---------------------------------------------------------------------------------------------- |
| Id              | `string`                        | ✅       |                                                                                                 |
| Name            | `string`                        | ✅       |                                                                                                 |
| DisplayName     | `string`                        | ✅       |                                                                                                 |
| Container       | `Container`                     | ✅       | Represents a container                                                                          |
| AutostartPolicy | `bool`                          | ✅       |                                                                                                 |
| RestartPolicy   | `ContainerRestartPolicy`        | ✅       |                                                                                                 |
| Replicas        | `long`                          | ✅       |                                                                                                 |
| CurrentState    | `ContainerGroupState`           | ✅       | Represents a container group state                                                              |
| CreateTime      | `string`                        | ✅       |                                                                                                 |
| UpdateTime      | `string`                        | ✅       |                                                                                                 |
| PendingChange   | `bool`                          | ✅       |                                                                                                 |
| Version         | `long`                          | ✅       |                                                                                                 |
| CountryCodes    | `List<CountryCode>`             | ❌       | List of countries nodes must be located in. Remove this field to permit nodes from any country. |
| Networking      | `ContainerGroupNetworking`      | ❌       | Represents container group networking parameters                                                |
| LivenessProbe   | `ContainerGroupLivenessProbe`   | ❌       | Represents the container group liveness probe                                                   |
| ReadinessProbe  | `ContainerGroupReadinessProbe`  | ❌       | Represents the container group readiness probe                                                  |
| StartupProbe    | `ContainerGroupStartupProbe`    | ❌       | Represents the container group startup probe                                                    |
| QueueConnection | `ContainerGroupQueueConnection` | ❌       | Represents container group queue connection                                                     |
| QueueAutoscaler | `QueueAutoscaler`               | ❌       | Represents the autoscaling rules for a queue                                                    |
