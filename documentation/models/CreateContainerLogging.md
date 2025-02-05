# CreateContainerLogging

**Properties**

| Name     | Type             | Required | Description |
| :------- | :--------------- | :------- | :---------- |
| Axiom    | LoggingAxiom2    | ❌       |             |
| Datadog  | LoggingDatadog2  | ❌       |             |
| NewRelic | LoggingNewRelic2 | ❌       |             |
| Splunk   | LoggingSplunk2   | ❌       |             |
| Tcp      | LoggingTcp2      | ❌       |             |
| Http     | LoggingHttp2     | ❌       |             |

# LoggingAxiom2

**Properties**

| Name     | Type   | Required | Description |
| :------- | :----- | :------- | :---------- |
| Host     | string | ✅       |             |
| ApiToken | string | ✅       |             |
| Dataset  | string | ✅       |             |

# LoggingDatadog2

**Properties**

| Name   | Type               | Required | Description |
| :----- | :----------------- | :------- | :---------- |
| Host   | string             | ✅       |             |
| ApiKey | string             | ✅       |             |
| Tags   | List<DatadogTags2> | ❌       |             |

# DatadogTags2

**Properties**

| Name  | Type   | Required | Description |
| :---- | :----- | :------- | :---------- |
| Name  | string | ✅       |             |
| Value | string | ✅       |             |

# LoggingNewRelic2

**Properties**

| Name         | Type   | Required | Description |
| :----------- | :----- | :------- | :---------- |
| Host         | string | ✅       |             |
| IngestionKey | string | ✅       |             |

# LoggingSplunk2

**Properties**

| Name  | Type   | Required | Description |
| :---- | :----- | :------- | :---------- |
| Host  | string | ✅       |             |
| Token | string | ✅       |             |

# LoggingTcp2

**Properties**

| Name | Type   | Required | Description |
| :--- | :----- | :------- | :---------- |
| Host | string | ✅       |             |
| Port | long   | ✅       |             |

# LoggingHttp2

**Properties**

| Name        | Type               | Required | Description |
| :---------- | :----------------- | :------- | :---------- |
| Host        | string             | ✅       |             |
| Port        | long               | ✅       |             |
| Format      | HttpFormat2        | ✅       |             |
| Compression | HttpCompression2   | ✅       |             |
| User        | string             | ❌       |             |
| Password    | string             | ❌       |             |
| Path        | string             | ❌       |             |
| Headers     | List<HttpHeaders3> | ❌       |             |

# HttpFormat2

**Properties**

| Name      | Type   | Required | Description  |
| :-------- | :----- | :------- | :----------- |
| Json      | string | ✅       | "json"       |
| JsonLines | string | ✅       | "json_lines" |

# HttpCompression2

**Properties**

| Name | Type   | Required | Description |
| :--- | :----- | :------- | :---------- |
| None | string | ✅       | "none"      |
| Gzip | string | ✅       | "gzip"      |

# HttpHeaders3

**Properties**

| Name  | Type   | Required | Description |
| :---- | :----- | :------- | :---------- |
| Name  | string | ✅       |             |
| Value | string | ✅       |             |
