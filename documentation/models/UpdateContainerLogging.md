# UpdateContainerLogging

**Properties**

| Name     | Type             | Required | Description |
| :------- | :--------------- | :------- | :---------- |
| Axiom    | LoggingAxiom3    | ❌       |             |
| Datadog  | LoggingDatadog3  | ❌       |             |
| NewRelic | LoggingNewRelic3 | ❌       |             |
| Splunk   | LoggingSplunk3   | ❌       |             |
| Tcp      | LoggingTcp3      | ❌       |             |
| Http     | LoggingHttp3     | ❌       |             |

# LoggingAxiom3

**Properties**

| Name     | Type   | Required | Description |
| :------- | :----- | :------- | :---------- |
| Host     | string | ✅       |             |
| ApiToken | string | ✅       |             |
| Dataset  | string | ✅       |             |

# LoggingDatadog3

**Properties**

| Name   | Type               | Required | Description |
| :----- | :----------------- | :------- | :---------- |
| Host   | string             | ✅       |             |
| ApiKey | string             | ✅       |             |
| Tags   | List<DatadogTags3> | ❌       |             |

# DatadogTags3

**Properties**

| Name  | Type   | Required | Description |
| :---- | :----- | :------- | :---------- |
| Name  | string | ✅       |             |
| Value | string | ✅       |             |

# LoggingNewRelic3

**Properties**

| Name         | Type   | Required | Description |
| :----------- | :----- | :------- | :---------- |
| Host         | string | ✅       |             |
| IngestionKey | string | ✅       |             |

# LoggingSplunk3

**Properties**

| Name  | Type   | Required | Description |
| :---- | :----- | :------- | :---------- |
| Host  | string | ✅       |             |
| Token | string | ✅       |             |

# LoggingTcp3

**Properties**

| Name | Type   | Required | Description |
| :--- | :----- | :------- | :---------- |
| Host | string | ✅       |             |
| Port | long   | ✅       |             |

# LoggingHttp3

**Properties**

| Name        | Type               | Required | Description |
| :---------- | :----------------- | :------- | :---------- |
| Host        | string             | ✅       |             |
| Port        | long               | ✅       |             |
| Format      | HttpFormat3        | ✅       |             |
| Compression | HttpCompression3   | ✅       |             |
| User        | string             | ❌       |             |
| Password    | string             | ❌       |             |
| Path        | string             | ❌       |             |
| Headers     | List<HttpHeaders4> | ❌       |             |

# HttpFormat3

**Properties**

| Name      | Type   | Required | Description  |
| :-------- | :----- | :------- | :----------- |
| Json      | string | ✅       | "json"       |
| JsonLines | string | ✅       | "json_lines" |

# HttpCompression3

**Properties**

| Name | Type   | Required | Description |
| :--- | :----- | :------- | :---------- |
| None | string | ✅       | "none"      |
| Gzip | string | ✅       | "gzip"      |

# HttpHeaders4

**Properties**

| Name  | Type   | Required | Description |
| :---- | :----- | :------- | :---------- |
| Name  | string | ✅       |             |
| Value | string | ✅       |             |
