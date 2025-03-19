# WorkloadError

Represents a workload error

**Properties**

| Name        | Type   | Required | Description                                                                             |
| :---------- | :----- | :------- | :-------------------------------------------------------------------------------------- |
| AllocatedAt | string | ✅       | The timestamp when the workload was initially allocated to a machine                    |
| Detail      | string | ✅       | A detailed error message describing the nature and cause of the workload failure        |
| FailedAt    | string | ✅       | The timestamp when the workload failure was detected or reported                        |
| InstanceId  | string | ✅       | The container group instance identifier.                                                |
| MachineId   | string | ✅       | The container group machine identifier.                                                 |
| Version     | long   | ✅       | The schema version number for this error record, used for tracking error format changes |
| StartedAt   | string | ❌       | The timestamp when the workload started execution, or null if it failed before starting |
