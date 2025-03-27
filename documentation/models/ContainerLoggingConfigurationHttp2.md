# ContainerLoggingConfigurationHttp2

Configuration for sending container logs to an HTTP endpoint. Defines how logs are formatted, compressed, and transmitted.

**Properties**

| Name        | Type                             | Required | Description                                                    |
| :---------- | :------------------------------- | :------- | :------------------------------------------------------------- |
| Host        | string                           | ✅       | The hostname or IP address of the HTTP logging endpoint        |
| Port        | long                             | ✅       | The port number of the HTTP logging endpoint (1-65535)         |
| Format      | ContainerLoggingHttpFormat       | ✅       | The format in which logs will be delivered                     |
| Compression | ContainerLoggingHttpCompression  | ✅       | The compression algorithm to apply to logs before transmission |
| User        | string                           | ❌       | Optional username for HTTP authentication                      |
| Password    | string                           | ❌       | Optional password for HTTP authentication                      |
| Path        | string                           | ❌       | Optional URL path for the HTTP endpoint                        |
| Headers     | List<ContainerLoggingHttpHeader> | ❌       | Optional HTTP headers to include in log transmission requests  |
