# ContainerGroupNetworking

Represents container group networking parameters

**Properties**

| Name                  | Type                                 | Required | Description |
| :-------------------- | :----------------------------------- | :------- | :---------- |
| Protocol              | ContainerNetworkingProtocol          | ✅       |             |
| Port                  | long                                 | ✅       |             |
| Auth                  | bool                                 | ✅       |             |
| Dns                   | string                               | ✅       |             |
| LoadBalancer          | ContainerGroupNetworkingLoadBalancer | ❌       |             |
| SingleConnectionLimit | bool                                 | ❌       |             |
| ClientRequestTimeout  | long                                 | ❌       |             |
| ServerResponseTimeout | long                                 | ❌       |             |

# ContainerGroupNetworkingLoadBalancer

**Properties**

| Name                     | Type   | Required | Description                   |
| :----------------------- | :----- | :------- | :---------------------------- |
| RoundRobin               | string | ✅       | "round_robin"                 |
| LeastNumberOfConnections | string | ✅       | "least_number_of_connections" |
