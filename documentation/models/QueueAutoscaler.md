# QueueAutoscaler

Represents the autoscaling rules for a queue

**Properties**

| Name                  | Type | Required | Description                                                     |
| :-------------------- | :--- | :------- | :-------------------------------------------------------------- |
| MinReplicas           | long | ✅       | The minimum number of instances the container can scale down to |
| MaxReplicas           | long | ✅       | The maximum number of instances the container can scale up to   |
| DesiredQueueLength    | long | ✅       |                                                                 |
| PollingPeriod         | long | ❌       | The period (in seconds) in which the queue checks the formula   |
| MaxUpscalePerMinute   | long | ❌       | The maximum number of instances that can be added per minute    |
| MaxDownscalePerMinute | long | ❌       | The maximum number of instances that can be removed per minute  |
