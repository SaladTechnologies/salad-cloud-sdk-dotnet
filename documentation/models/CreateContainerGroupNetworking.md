# CreateContainerGroupNetworking

Network configuration for container groups specifying connectivity parameters, including authentication, protocol, and timeout settings

**Properties**

| Name                  | Type                                                                                  | Required | Description                                                                                                                                                       |
| :-------------------- | :------------------------------------------------------------------------------------ | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Auth                  | bool                                                                                  | ✅       | Determines whether authentication is required for network connections to the container group                                                                      |
| Port                  | long                                                                                  | ✅       | The container group networking port.                                                                                                                              |
| Protocol              | [ContainerNetworkingProtocol](ContainerNetworkingProtocol.md)                         | ✅       | Defines the communication protocol used for network traffic between containers or external systems. Currently supports HTTP protocol for web-based communication. |
| ClientRequestTimeout  | long                                                                                  | ❌       | The container group networking client request timeout.                                                                                                            |
| LoadBalancer          | [TheContainerGroupNetworkingLoadBalancer](TheContainerGroupNetworkingLoadBalancer.md) | ❌       | The container group networking load balancer.                                                                                                                     |
| ServerResponseTimeout | long                                                                                  | ❌       | The container group networking server response timeout.                                                                                                           |
| SingleConnectionLimit | bool                                                                                  | ❌       | The container group networking single connection limit flag.                                                                                                      |
