# InferenceEndpointCollection

Represents a page from the collection of inference endpoints.

**Properties**

| Name      | Type                                            | Required | Description                                  |
| :-------- | :---------------------------------------------- | :------- | :------------------------------------------- |
| Items     | List<[InferenceEndpoint](InferenceEndpoint.md)> | ✅       | The list of inference endpoints.             |
| Page      | long                                            | ✅       | The page number.                             |
| PageSize  | long                                            | ✅       | The maximum number of items per page.        |
| TotalSize | long                                            | ✅       | The total number of items in the collection. |
