# Container

Represents a container

**Properties**

| Name                 | Type                            | Required | Description                                  |
| :------------------- | :------------------------------ | :------- | :------------------------------------------- |
| Image                | `string`                        | ✅       |                                              |
| Resources            | `ContainerResourceRequirements` | ✅       | Represents a container resource requirements |
| Command              | `List<string>`                  | ✅       |                                              |
| Priority             | `ContainerGroupPriority`        | ❌       |                                              |
| Size                 | `long`                          | ❌       |                                              |
| Hash                 | `string`                        | ❌       |                                              |
| EnvironmentVariables | `object`                        | ❌       |                                              |
| Logging              | `ContainerLogging`              | ❌       |                                              |

# ContainerLogging

**Properties**

| Name     | Type               | Required | Description |
| :------- | :----------------- | :------- | :---------- |
| Axiom    | `LoggingAxiom1`    | ❌       |             |
| Datadog  | `LoggingDatadog1`  | ❌       |             |
| NewRelic | `LoggingNewRelic1` | ❌       |             |
| Splunk   | `LoggingSplunk1`   | ❌       |             |
| Tcp      | `LoggingTcp1`      | ❌       |             |
| Http     | `LoggingHttp1`     | ❌       |             |

# LoggingAxiom1

**Properties**

| Name     | Type     | Required | Description |
| :------- | :------- | :------- | :---------- |
| Host     | `string` | ✅       |             |
| ApiToken | `string` | ✅       |             |
| Dataset  | `string` | ✅       |             |

# LoggingDatadog1

**Properties**

| Name   | Type                 | Required | Description |
| :----- | :------------------- | :------- | :---------- |
| Host   | `string`             | ✅       |             |
| ApiKey | `string`             | ✅       |             |
| Tags   | `List<DatadogTags1>` | ❌       |             |

# DatadogTags1

**Properties**

| Name  | Type     | Required | Description |
| :---- | :------- | :------- | :---------- |
| Name  | `string` | ✅       |             |
| Value | `string` | ✅       |             |

# LoggingNewRelic1

**Properties**

| Name         | Type     | Required | Description |
| :----------- | :------- | :------- | :---------- |
| Host         | `string` | ✅       |             |
| IngestionKey | `string` | ✅       |             |

# LoggingSplunk1

**Properties**

| Name  | Type     | Required | Description |
| :---- | :------- | :------- | :---------- |
| Host  | `string` | ✅       |             |
| Token | `string` | ✅       |             |

# LoggingTcp1

**Properties**

| Name | Type     | Required | Description |
| :--- | :------- | :------- | :---------- |
| Host | `string` | ✅       |             |
| Port | `long`   | ✅       |             |

# LoggingHttp1

**Properties**

| Name        | Type                 | Required | Description |
| :---------- | :------------------- | :------- | :---------- |
| Host        | `string`             | ✅       |             |
| Port        | `long`               | ✅       |             |
| Format      | `HttpFormat1`        | ✅       |             |
| Compression | `HttpCompression1`   | ✅       |             |
| User        | `string`             | ❌       |             |
| Password    | `string`             | ❌       |             |
| Path        | `string`             | ❌       |             |
| Headers     | `List<HttpHeaders1>` | ❌       |             |

# HttpFormat1

**Properties**

| Name      | Type     | Required | Description  |
| :-------- | :------- | :------- | :----------- |
| Json      | `string` | ✅       | "json"       |
| JsonLines | `string` | ✅       | "json_lines" |

# HttpCompression1

**Properties**

| Name | Type     | Required | Description |
| :--- | :------- | :------- | :---------- |
| None | `string` | ✅       | "none"      |
| Gzip | `string` | ✅       | "gzip"      |

# HttpHeaders1

**Properties**

| Name  | Type     | Required | Description |
| :---- | :------- | :------- | :---------- |
| Name  | `string` | ✅       |             |
| Value | `string` | ✅       |             |
