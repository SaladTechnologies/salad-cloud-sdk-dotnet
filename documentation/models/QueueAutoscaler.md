# QueueAutoscaler

Represents the autoscaling rules for a queue

**Properties**

| Name                  | Type   | Required | Description |
| :-------------------- | :----- | :------- | :---------- |
| MinReplicas           | `long` | ✅       |             |
| MaxReplicas           | `long` | ✅       |             |
| DesiredQueueLength    | `long` | ✅       |             |
| PollingPeriod         | `long` | ❌       |             |
| MaxUpscalePerMinute   | `long` | ❌       |             |
| MaxDownscalePerMinute | `long` | ❌       |             |
