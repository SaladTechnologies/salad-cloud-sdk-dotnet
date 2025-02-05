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
