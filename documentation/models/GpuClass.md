# GpuClass

Represents a GPU Class

**Properties**

| Name         | Type                                    | Required | Description                                          |
| :----------- | :-------------------------------------- | :------- | :--------------------------------------------------- |
| Id           | string                                  | ✅       | The unique identifier                                |
| Name         | string                                  | ✅       | The GPU class name                                   |
| Prices       | List<[GpuClassPrice](GpuClassPrice.md)> | ✅       | The list of prices for each container group priority |
| GpuClassType | GpuClassType                            | ❌       | The type of GPU class                                |
| GpuCount     | long                                    | ❌       | The number of GPUs in the cluster                    |
| IsHighDemand | bool                                    | ❌       | Whether the GPU class is in high demand              |
| MaxRam       | long                                    | ❌       | The maximum RAM amount in MB                         |
| MaxStorage   | long                                    | ❌       | The maximum storage amount in bytes                  |
| MaxVcpu      | long                                    | ❌       | The maximum vCPU count                               |
| MinRam       | long                                    | ❌       | The minimum RAM amount in MB                         |
| MinStorage   | long                                    | ❌       | The minimum storage amount in bytes                  |
| MinVcpu      | long                                    | ❌       | The minimum vCPU count                               |

# GpuClassType

The type of GPU class

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Community | string | ✅       | "community" |
| Secure    | string | ✅       | "secure"    |
