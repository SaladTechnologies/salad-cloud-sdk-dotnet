# ContainerGroupLivenessProbe

Represents the container group liveness probe

**Properties**

| Name                | Type                    | Required | Description |
| :------------------ | :---------------------- | :------- | :---------- |
| InitialDelaySeconds | long                    | ✅       |             |
| PeriodSeconds       | long                    | ✅       |             |
| TimeoutSeconds      | long                    | ✅       |             |
| SuccessThreshold    | long                    | ✅       |             |
| FailureThreshold    | long                    | ✅       |             |
| Tcp                 | ContainerGroupProbeTcp  | ❌       |             |
| Http                | ContainerGroupProbeHttp | ❌       |             |
| Grpc                | ContainerGroupProbeGrpc | ❌       |             |
| Exec                | ContainerGroupProbeExec | ❌       |             |
