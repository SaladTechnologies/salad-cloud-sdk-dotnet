# CreateContainerGroup

Represents a request to create a container group

**Properties**

| Name            | Type                             | Required | Description                                                                                     |
| :-------------- | :------------------------------- | :------- | :---------------------------------------------------------------------------------------------- |
| Name            | `string`                         | ✅       |                                                                                                 |
| Container       | `CreateContainer`                | ✅       | Represents a container                                                                          |
| AutostartPolicy | `bool`                           | ✅       |                                                                                                 |
| RestartPolicy   | `ContainerRestartPolicy`         | ✅       |                                                                                                 |
| Replicas        | `long`                           | ✅       |                                                                                                 |
| DisplayName     | `string`                         | ❌       |                                                                                                 |
| CountryCodes    | `List<CountryCode>`              | ❌       | List of countries nodes must be located in. Remove this field to permit nodes from any country. |
| Networking      | `CreateContainerGroupNetworking` | ❌       | Represents container group networking parameters                                                |
| LivenessProbe   | `ContainerGroupLivenessProbe`    | ❌       | Represents the container group liveness probe                                                   |
| ReadinessProbe  | `ContainerGroupReadinessProbe`   | ❌       | Represents the container group readiness probe                                                  |
| StartupProbe    | `ContainerGroupStartupProbe`     | ❌       | Represents the container group startup probe                                                    |
| QueueConnection | `ContainerGroupQueueConnection`  | ❌       | Represents container group queue connection                                                     |
| QueueAutoscaler | `QueueAutoscaler`                | ❌       | Represents the autoscaling rules for a queue                                                    |
