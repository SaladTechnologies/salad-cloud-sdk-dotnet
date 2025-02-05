# CreateContainerRegistryAuthentication

**Properties**

| Name      | Type                             | Required | Description |
| :-------- | :------------------------------- | :------- | :---------- |
| Basic     | RegistryAuthenticationBasic1     | ❌       |             |
| GcpGcr    | RegistryAuthenticationGcpGcr1    | ❌       |             |
| AwsEcr    | RegistryAuthenticationAwsEcr1    | ❌       |             |
| DockerHub | RegistryAuthenticationDockerHub1 | ❌       |             |
| GcpGar    | RegistryAuthenticationGcpGar1    | ❌       |             |

# RegistryAuthenticationBasic1

**Properties**

| Name     | Type   | Required | Description |
| :------- | :----- | :------- | :---------- |
| Username | string | ✅       |             |
| Password | string | ✅       |             |

# RegistryAuthenticationGcpGcr1

**Properties**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| ServiceKey | string | ✅       |             |

# RegistryAuthenticationAwsEcr1

**Properties**

| Name            | Type   | Required | Description |
| :-------------- | :----- | :------- | :---------- |
| AccessKeyId     | string | ✅       |             |
| SecretAccessKey | string | ✅       |             |

# RegistryAuthenticationDockerHub1

**Properties**

| Name                | Type   | Required | Description |
| :------------------ | :----- | :------- | :---------- |
| Username            | string | ✅       |             |
| PersonalAccessToken | string | ✅       |             |

# RegistryAuthenticationGcpGar1

**Properties**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| ServiceKey | string | ✅       |             |
