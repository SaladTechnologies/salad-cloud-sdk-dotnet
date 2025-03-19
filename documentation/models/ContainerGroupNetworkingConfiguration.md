# ContainerGroupNetworkingConfiguration

Network configuration for container groups that defines connectivity, routing, and access control settings

**Properties**

| Name                  | Type                                    | Required | Description                                                                                                                                                       |
| :-------------------- | :-------------------------------------- | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Auth                  | bool                                    | ✅       | Whether authentication is required for network access to the container group                                                                                      |
| Dns                   | string                                  | ✅       | Domain name or URL endpoint for the container group's network interface                                                                                           |
| LoadBalancer          | TheContainerGroupNetworkingLoadBalancer | ✅       | The container group networking load balancer.                                                                                                                     |
| Port                  | long                                    | ✅       | The container group networking port.                                                                                                                              |
| Protocol              | ContainerNetworkingProtocol             | ✅       | Defines the communication protocol used for network traffic between containers or external systems. Currently supports HTTP protocol for web-based communication. |
| ClientRequestTimeout  | long                                    | ❌       | The container group networking client request timeout.                                                                                                            |
| ServerResponseTimeout | long                                    | ❌       | The container group networking server response timeout.                                                                                                           |
| SingleConnectionLimit | bool                                    | ❌       | The container group networking single connection limit flag.                                                                                                      |
