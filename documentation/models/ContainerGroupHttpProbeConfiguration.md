# ContainerGroupHttpProbeConfiguration

Defines HTTP probe configuration for container health checks within a container group.

**Properties**

| Name    | Type                                                                    | Required | Description                                                                                                                                                                        |
| :------ | :---------------------------------------------------------------------- | :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Headers | List<[ContainerGroupProbeHttpHeader](ContainerGroupProbeHttpHeader.md)> | ✅       | A collection of HTTP header name-value pairs used for configuring requests and responses in container group endpoints. Each header consists of a name and its corresponding value. |
| Path    | string                                                                  | ✅       | The HTTP path that will be probed to check container health.                                                                                                                       |
| Port    | long                                                                    | ✅       | The TCP port number to which the HTTP request will be sent.                                                                                                                        |
| Scheme  | [HttpScheme](HttpScheme.md)                                             | ✅       | The protocol scheme used for HTTP probe requests in container health checks.                                                                                                       |
