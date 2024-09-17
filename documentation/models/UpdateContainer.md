# UpdateContainer

Represents an update container object

**Properties**

| Name                   | Type                                  | Required | Description                                                                                      |
| :--------------------- | :------------------------------------ | :------- | :----------------------------------------------------------------------------------------------- |
| Image                  | string                                | ❌       |                                                                                                  |
| Resources\_            | Resources                             | ❌       |                                                                                                  |
| Command                | List<string>                          | ❌       | Pass a command (and optional arguments) to override the ENTRYPOINT and CMD of a container image. |
| Priority               | ContainerGroupPriority                | ❌       |                                                                                                  |
| EnvironmentVariables   | object                                | ❌       |                                                                                                  |
| Logging                | UpdateContainerLogging                | ❌       |                                                                                                  |
| RegistryAuthentication | UpdateContainerRegistryAuthentication | ❌       |                                                                                                  |

# Resources

**Properties**

| Name          | Type         | Required | Description |
| :------------ | :----------- | :------- | :---------- |
| Cpu           | long         | ❌       |             |
| Memory        | long         | ❌       |             |
| GpuClasses    | List<string> | ❌       |             |
| StorageAmount | long         | ❌       |             |

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

# UpdateContainerRegistryAuthentication

**Properties**

| Name      | Type                             | Required | Description |
| :-------- | :------------------------------- | :------- | :---------- |
| Basic     | RegistryAuthenticationBasic2     | ❌       |             |
| GcpGcr    | RegistryAuthenticationGcpGcr2    | ❌       |             |
| AwsEcr    | RegistryAuthenticationAwsEcr2    | ❌       |             |
| DockerHub | RegistryAuthenticationDockerHub2 | ❌       |             |
| GcpGar    | RegistryAuthenticationGcpGar2    | ❌       |             |

# RegistryAuthenticationBasic2

**Properties**

| Name     | Type   | Required | Description |
| :------- | :----- | :------- | :---------- |
| Username | string | ✅       |             |
| Password | string | ✅       |             |

# RegistryAuthenticationGcpGcr2

**Properties**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| ServiceKey | string | ✅       |             |

# RegistryAuthenticationAwsEcr2

**Properties**

| Name            | Type   | Required | Description |
| :-------------- | :----- | :------- | :---------- |
| AccessKeyId     | string | ✅       |             |
| SecretAccessKey | string | ✅       |             |

# RegistryAuthenticationDockerHub2

**Properties**

| Name                | Type   | Required | Description |
| :------------------ | :----- | :------- | :---------- |
| Username            | string | ✅       |             |
| PersonalAccessToken | string | ✅       |             |

# RegistryAuthenticationGcpGar2

**Properties**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| ServiceKey | string | ✅       |             |
