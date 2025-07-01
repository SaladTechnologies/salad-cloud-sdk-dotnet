# GpuClass

Represents a GPU Class

**Properties**

| Name          | Type                | Required | Description                                          |
| :------------ | :------------------ | :------- | :--------------------------------------------------- |
| Id            | string              | ✅       | The unique identifier                                |
| Name          | string              | ✅       | The GPU class name                                   |
| Prices        | List<GpuClassPrice> | ✅       | The list of prices for each container group priority |
| IsHighDemand  | bool                | ❌       | Whether the GPU class is in high demand              |
| GpuClassType1 | GpuClassType        | ❌       | The type of GPU class                                |
| MinVcpu       | long                | ❌       | The minimum vCPU count                               |
| MaxVcpu       | long                | ❌       | The maximum vCPU count                               |
| MinRam        | long                | ❌       | The minimum RAM amount in GB                         |
| MaxRam        | long                | ❌       | The maximum RAM amount in GB                         |
| MinStorage    | long                | ❌       | The minimum storage amount in GB                     |
| MaxStorage    | long                | ❌       | The maximum storage amount in GB                     |

# GpuClassType

The type of GPU class

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Community | string | ✅       | "community" |
| Secure    | string | ✅       | "secure"    |
