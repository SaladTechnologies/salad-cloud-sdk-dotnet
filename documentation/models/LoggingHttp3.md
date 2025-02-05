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
