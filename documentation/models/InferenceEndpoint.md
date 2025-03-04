# InferenceEndpoint

Represents an inference endpoint

**Properties**

| Name             | Type   | Required | Description                                                                 |
| :--------------- | :----- | :------- | :-------------------------------------------------------------------------- |
| Id               | string | ✅       | The inference endpoint identifier.                                          |
| Name             | string | ✅       | The inference endpoint name.                                                |
| OrganizationName | string | ✅       | The organization name.                                                      |
| DisplayName      | string | ✅       | The display-friendly name of the resource.                                  |
| Description      | string | ✅       | The detailed description of the resource.                                   |
| Readme           | string | ✅       | A markdown file containing a detailed description of the inference endpoint |
| PriceDescription | string | ✅       | A description of the price                                                  |
| IconUrl          | string | ✅       | The URL of the icon image                                                   |
| InputSchema      | string | ✅       | The input schema                                                            |
| OutputSchema     | string | ✅       | The output schema                                                           |
