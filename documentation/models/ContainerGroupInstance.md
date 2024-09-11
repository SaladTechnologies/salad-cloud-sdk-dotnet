# ContainerGroupInstance

Represents the details of a single container group instance

**Properties**

| Name       | Type     | Required | Description                                                                                                                                            |
| :--------- | :------- | :------- | :----------------------------------------------------------------------------------------------------------------------------------------------------- |
| InstanceId | `string` | ✅       | The unique instance ID                                                                                                                                 |
| MachineId  | `string` | ✅       | The machine ID                                                                                                                                         |
| State\_    | `State`  | ✅       | The state of the container group instance                                                                                                              |
| UpdateTime | `string` | ✅       | The UTC date & time when the workload on this machine transitioned to the current state                                                                |
| Version    | `long`   | ✅       | The version of the running container group                                                                                                             |
| Ready      | `bool`   | ❌       | Specifies whether the container group instance is currently passing its readiness check. If no readiness probe is defined, is true once fully started. |
| Started    | `bool`   | ❌       | Specifies whether the container group instance passed its startup probe. Is always true when no startup probe is defined.                              |

# State

The state of the container group instance

**Properties**

| Name        | Type     | Required | Description   |
| :---------- | :------- | :------- | :------------ |
| Allocating  | `string` | ✅       | "allocating"  |
| Downloading | `string` | ✅       | "downloading" |
| Creating    | `string` | ✅       | "creating"    |
| Running     | `string` | ✅       | "running"     |
| Stopping    | `string` | ✅       | "stopping"    |
