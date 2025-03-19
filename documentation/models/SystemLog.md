# SystemLog

Represents a system log

**Properties**

| Name                  | Type   | Required | Description                                       |
| :-------------------- | :----- | :------- | :------------------------------------------------ |
| EventName             | string | ✅       | The name of the event                             |
| EventTime             | string | ✅       | The UTC date & time when the log item was created |
| ResourceCpu           | long   | ✅       | The number of CPUs                                |
| ResourceGpuClass      | string | ✅       | The GPU class name                                |
| ResourceMemory        | long   | ✅       | The memory amount in MB                           |
| ResourceStorageAmount | long   | ✅       | The storage amount in bytes                       |
| Version               | string | ✅       | The version instance ID                           |
| InstanceId            | string | ❌       | The container group instance identifier.          |
| MachineId             | string | ❌       | The container group machine identifier.           |
