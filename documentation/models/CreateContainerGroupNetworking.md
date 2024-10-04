# CreateContainerGroupNetworking

Represents container group networking parameters

**Properties**

| Name                  | Type                                       | Required | Description |
| :-------------------- | :----------------------------------------- | :------- | :---------- |
| Protocol              | ContainerNetworkingProtocol                | ✅       |             |
| Port                  | long                                       | ✅       |             |
| Auth                  | bool                                       | ✅       |             |
| LoadBalancer          | CreateContainerGroupNetworkingLoadBalancer | ❌       |             |
| SingleConnectionLimit | bool                                       | ❌       |             |
| ClientRequestTimeout  | long                                       | ❌       |             |
| ServerResponseTimeout | long                                       | ❌       |             |

# CreateContainerGroupNetworkingLoadBalancer

**Properties**

| Name                     | Type   | Required | Description                   |
| :----------------------- | :----- | :------- | :---------------------------- |
| RoundRobin               | string | ✅       | "round_robin"                 |
| LeastNumberOfConnections | string | ✅       | "least_number_of_connections" |
