# ContainerGroupScalingAction

Represents a scaling action configuration for a container group

**Properties**

| Name     | Type   | Required | Description                                                           |
| :------- | :----- | :------- | :-------------------------------------------------------------------- |
| Replicas | long   | ✅       | The number of replicas to scale to during the scheduled period        |
| Schedule | string | ✅       | The cron-style schedule string defining when the scaling should occur |
