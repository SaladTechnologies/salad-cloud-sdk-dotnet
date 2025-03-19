# DatadogLoggingConfiguration

Configuration for forwarding container logs to Datadog monitoring service.

**Properties**

| Name   | Type                                | Required | Description                                                                           |
| :----- | :---------------------------------- | :------- | :------------------------------------------------------------------------------------ |
| Host   | string                              | ✅       | The Datadog intake server host URL where logs will be sent.                           |
| ApiKey | string                              | ✅       | The Datadog API key used for authentication when sending logs.                        |
| Tags   | List<DatadogTagForContainerLogging> | ✅       | Optional metadata tags to attach to logs for filtering and categorization in Datadog. |
