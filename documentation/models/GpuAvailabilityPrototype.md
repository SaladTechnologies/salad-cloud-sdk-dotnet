# GpuAvailabilityPrototype

**Properties**

| Name          | Type                                | Required | Description                                               |
| :------------ | :---------------------------------- | :------- | :-------------------------------------------------------- |
| GpuClasses    | List<string>                        | ✅       | A list of available GPU class names                       |
| CountryCodes  | List<[CountryCode](CountryCode.md)> | ❌       | A list of country codes where the resources are available |
| Cpu           | long                                | ❌       | The number of available CPU cores                         |
| Memory        | long                                | ❌       | The amount of available memory in MB                      |
| StorageAmount | long                                | ❌       | The amount of available storage in bytes                  |
