# ContainerLoggingConfigurationHttp2

Configuration for sending container logs to an HTTP endpoint. Defines how logs are formatted, compressed, and transmitted.

**Properties**

| Name        | Type                                          | Required | Description                                                    |
| :---------- | :-------------------------------------------- | :------- | :------------------------------------------------------------- |
| Host        | string                                        | ✅       | The hostname or IP address of the HTTP logging endpoint        |
| Port        | long                                          | ✅       | The port number of the HTTP logging endpoint (1-65535)         |
| Format      | ContainerHttpLoggingConfigurationFormat2      | ✅       | The format in which logs will be delivered                     |
| Compression | ContainerHttpLoggingConfigurationCompression2 | ✅       | The compression algorithm to apply to logs before transmission |
| User        | string                                        | ❌       | Optional username for HTTP authentication                      |
| Password    | string                                        | ❌       | Optional password for HTTP authentication                      |
| Path        | string                                        | ❌       | Optional URL path for the HTTP endpoint                        |
| Headers     | List<ContainerLoggingHttpHeader>              | ❌       | Optional HTTP headers to include in log transmission requests  |

# ContainerHttpLoggingConfigurationFormat2

The format in which logs will be delivered

**Properties**

| Name      | Type   | Required | Description  |
| :-------- | :----- | :------- | :----------- |
| Json      | string | ✅       | "json"       |
| JsonLines | string | ✅       | "json_lines" |

# ContainerHttpLoggingConfigurationCompression2

The compression algorithm to apply to logs before transmission

**Properties**

| Name | Type   | Required | Description |
| :--- | :----- | :------- | :---------- |
| None | string | ✅       | "none"      |
| Gzip | string | ✅       | "gzip"      |
