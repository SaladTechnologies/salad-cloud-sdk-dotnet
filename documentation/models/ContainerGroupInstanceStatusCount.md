# ContainerGroupInstanceStatusCount

A summary of container group instances categorized by their current lifecycle status

**Properties**

| Name            | Type | Required | Description                                                                    |
| :-------------- | :--- | :------- | :----------------------------------------------------------------------------- |
| AllocatingCount | long | ✅       | The number of container instances that are currently being allocated resources |
| CreatingCount   | long | ✅       | The number of container instances that are in the process of being created     |
| RunningCount    | long | ✅       | The number of container instances that are currently running and operational   |
| StoppingCount   | long | ✅       | The number of container instances that are in the process of stopping          |
