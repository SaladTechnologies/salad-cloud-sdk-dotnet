# UpdateContainerGroup

Represents a request to update a container group

**Properties**

| Name           | Type                             | Required | Description                                                                                     |
| :------------- | :------------------------------- | :------- | :---------------------------------------------------------------------------------------------- |
| DisplayName    | `string`                         | ❌       |                                                                                                 |
| Container      | `UpdateContainer`                | ❌       | Represents an update container object                                                           |
| Replicas       | `long`                           | ❌       |                                                                                                 |
| CountryCodes   | `List<CountryCode>`              | ❌       | List of countries nodes must be located in. Remove this field to permit nodes from any country. |
| Networking     | `UpdateContainerGroupNetworking` | ❌       | Represents update container group networking parameters                                         |
| LivenessProbe  | `ContainerGroupLivenessProbe`    | ❌       | Represents the container group liveness probe                                                   |
| ReadinessProbe | `ContainerGroupReadinessProbe`   | ❌       | Represents the container group readiness probe                                                  |
| StartupProbe   | `ContainerGroupStartupProbe`     | ❌       | Represents the container group startup probe                                                    |
