# ContainerResourceUpdateSchema

Defines the resource specifications that can be modified for a container group, including CPU, memory, GPU classes, and storage allocations.

**Properties**

| Name          | Type         | Required | Description                                                                                  |
| :------------ | :----------- | :------- | :------------------------------------------------------------------------------------------- |
| Cpu           | long         | ❌       | The number of CPU cores to allocate to the container (between 1 and 16 cores).               |
| Memory        | long         | ❌       | The amount of memory to allocate to the container in megabytes (between 1024MB and 61440MB). |
| GpuClasses    | List<string> | ❌       | List of GPU class identifiers that the container can use, specified as UUIDs.                |
| StorageAmount | long         | ❌       | The amount of storage to allocate to the container in bytes (between 1GB and 250GB).         |
