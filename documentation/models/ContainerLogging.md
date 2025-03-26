# ContainerLogging

Configuration options for directing container logs to a logging provider. This schema enables you to specify a single logging destination for container output, supporting monitoring, debugging, and analytics use cases. Each provider has its own configuration parameters defined in the referenced schemas. Only one logging provider can be selected at a time.

**Properties**

| Name     | Type                                | Required | Description                                                                                                                                                                               |
| :------- | :---------------------------------- | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Axiom    | AxiomLoggingConfiguration           | ❌       | Configuration settings for integrating container logs with the Axiom logging service. When specified, container logs will be forwarded to the Axiom instance defined by these parameters. |
| Datadog  | DatadogLoggingConfiguration         | ❌       | Configuration for forwarding container logs to Datadog monitoring service.                                                                                                                |
| Http     | ContainerLoggingConfigurationHttp1  | ❌       | Configuration for sending container logs to an HTTP endpoint. Defines how logs are formatted, compressed, and transmitted.                                                                |
| NewRelic | NewRelicLoggingConfiguration        | ❌       | Configuration for sending container logs to New Relic's log management platform.                                                                                                          |
| Splunk   | ContainerLoggingSplunkConfiguration | ❌       | Configuration settings for forwarding container logs to a Splunk instance.                                                                                                                |
| Tcp      | TcpLoggingConfiguration             | ❌       | Configuration for forwarding container logs to a remote TCP endpoint                                                                                                                      |
