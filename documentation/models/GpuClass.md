# GpuClass

Represents a GPU Class

**Properties**

| Name         | Type                  | Required | Description                                          |
| :----------- | :-------------------- | :------- | :--------------------------------------------------- |
| Id           | `string`              | ✅       | The unique identifier                                |
| Name         | `string`              | ✅       | The GPU class name                                   |
| Prices       | `List<GpuClassPrice>` | ✅       | The list of prices for each container group priority |
| IsHighDemand | `bool`                | ❌       | Whether the GPU class is in high demand              |
