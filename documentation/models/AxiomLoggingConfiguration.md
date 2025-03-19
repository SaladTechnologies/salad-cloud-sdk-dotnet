# AxiomLoggingConfiguration

Configuration settings for integrating container logs with the Axiom logging service. When specified, container logs will be forwarded to the Axiom instance defined by these parameters.

**Properties**

| Name     | Type   | Required | Description                                                                   |
| :------- | :----- | :------- | :---------------------------------------------------------------------------- |
| Host     | string | ✅       | The Axiom host URL where logs will be sent (e.g. logs.axiom.co)               |
| ApiToken | string | ✅       | Authentication token for the Axiom API with appropriate write permissions     |
| Dataset  | string | ✅       | Name of the Axiom dataset where the container logs will be stored and indexed |
